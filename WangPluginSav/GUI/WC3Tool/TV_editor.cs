using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WC3Tool;

partial class TV_editor : Form
{
	private SAV3 sav3file;

	public string savfilter = MainScreen.savfilter;

	private TV_EVENTS events;

	private SHOW ingame_swarm;

	private TV_SHOWS shows;

	private SWARM swarm;

	

	public TV_editor(SAV3 save)
	{
		InitializeComponent();
		sav3file = save;
		events = new TV_EVENTS(sav3file.get_TV_EVENT());
		ingame_swarm = new SHOW(sav3file.get_TV_OUTBREAK());
		shows = new TV_SHOWS(sav3file.get_TV_SHOWS());
		swarm = new SWARM(sav3file.get_TV_OUTBREAK_EXTRA());
		load_data();
	}

	private void load_data()
	{
		load_event();
		load_swarm();
		load_show();
	}

	private void load_event()
	{
		event_id.SelectedIndex = events.events[(int)event_slot.Value].ID;
		event_status.SelectedIndex = events.events[(int)event_slot.Value].status;
		event_days.Value = events.events[(int)event_slot.Value].days_to_tv;
	}

	private void set_event()
	{
		events.events[(int)event_slot.Value].ID = (byte)event_id.SelectedIndex;
		events.events[(int)event_slot.Value].status = (byte)event_status.SelectedIndex;
		events.events[(int)event_slot.Value].days_to_tv = (ushort)event_days.Value;
	}

	private void load_swarm()
	{
		current_species.SelectedIndex = swarm.species;
		current_level.Value = swarm.level;
		current_move1.SelectedIndex = swarm.move1;
		current_move2.SelectedIndex = swarm.move2;
		current_move3.SelectedIndex = swarm.move3;
		current_move4.SelectedIndex = swarm.move4;
		current_map.Value = swarm.map;
		current_appearance.Value = swarm.appearance;
		current_remaining.Value = swarm.remaining_days;
	}

	private void set_swarm()
	{
		swarm.species = (ushort)current_species.SelectedIndex;
		swarm.level = (byte)current_level.Value;
		swarm.move1 = (ushort)current_move1.SelectedIndex;
		swarm.move2 = (ushort)current_move2.SelectedIndex;
		swarm.move3 = (ushort)current_move3.SelectedIndex;
		swarm.move4 = (ushort)current_move4.SelectedIndex;
		swarm.map = (ushort)current_map.Value;
		swarm.appearance = (byte)current_appearance.Value;
		swarm.remaining_days = (byte)current_remaining.Value;
	}

	private void load_show()
	{
		if (tv_slot.Value == 0m)
		{
			tv_id.Value = ingame_swarm.ID;
			tv_status.SelectedIndex = ingame_swarm.status;
			tv_tid.Value = ingame_swarm.TID_own;
			tv_mix_tid.Value = ingame_swarm.TID_mixed;
		}
		else
		{
			tv_id.Value = shows.shows[(int)(tv_slot.Value - 1m)].ID;
			tv_status.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].status;
			tv_tid.Value = shows.shows[(int)(tv_slot.Value - 1m)].TID_own;
			tv_mix_tid.Value = shows.shows[(int)(tv_slot.Value - 1m)].TID_mixed;
		}
		load_outbreak();
	}

	private void Save_butClick(object sender, EventArgs e)
	{
		events.set_events();
		shows.set_shows();
		sav3file.set_TV_EVENT(events.Data);
		sav3file.set_TV_OUTBREAK(ingame_swarm.Data);
		sav3file.set_TV_SHOWS(shows.Data);
		sav3file.set_TV_OUTBREAK_EXTRA(swarm.Data);
		sav3file.update_section_chk(3);
		FileIO.save_data(sav3file.Data, savfilter);
	}

	private void Event_slotValueChanged(object sender, EventArgs e)
	{
		load_event();
	}

	private void Swarm_deleteClick(object sender, EventArgs e)
	{
		delete_current_swarm();
		load_swarm();
	}

	private void delete_current_swarm()
	{
		int num = 0;
		for (num = 0; num < SWARM.swarm_size; num++)
		{
			swarm.Data[num] = 0;
		}
	}

	private void load_outbreak()
	{
		if (tv_slot.Value == 0m)
		{
			tv_outbreak_group.Enabled = true;
			outbreak_activation.Value = ingame_swarm.outbreak_days_to_tv;
			outbreak_map.Value = ingame_swarm.outbreak_map;
			outbreak_availability.Value = ingame_swarm.outbreak_appearance;
			outbreak_remaining.Value = ingame_swarm.outbreak_appearance;
			outbreak_species.SelectedIndex = ingame_swarm.outbreak_species;
			outbreak_level.Value = ingame_swarm.outbreak_level;
			outbreak_move1.SelectedIndex = ingame_swarm.outbreak_move1;
			outbreak_move2.SelectedIndex = ingame_swarm.outbreak_move2;
			outbreak_move3.SelectedIndex = ingame_swarm.outbreak_move3;
			outbreak_move4.SelectedIndex = ingame_swarm.outbreak_move4;
		}
		else if (tv_slot.Value != 0m && tv_id.Value == 41m)
		{
			tv_outbreak_group.Enabled = true;
			outbreak_activation.Value = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_days_to_tv;
			outbreak_map.Value = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_map;
			outbreak_availability.Value = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_appearance;
			outbreak_remaining.Value = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_appearance;
			outbreak_species.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_species;
			outbreak_level.Value = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_level;
			outbreak_move1.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move1;
			outbreak_move2.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move2;
			outbreak_move3.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move3;
			outbreak_move4.SelectedIndex = shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move4;
		}
		else
		{
			tv_outbreak_group.Enabled = false;
		}
	}

	private void Outbreak_applyClick(object sender, EventArgs e)
	{
		if (tv_slot.Value == 0m)
		{
			ingame_swarm.outbreak_days_to_tv = (ushort)outbreak_activation.Value;
			ingame_swarm.outbreak_map = (ushort)outbreak_map.Value;
			ingame_swarm.outbreak_appearance = (byte)outbreak_availability.Value;
			ingame_swarm.outbreak_appearance = (byte)outbreak_remaining.Value;
			ingame_swarm.outbreak_species = (ushort)outbreak_species.SelectedIndex;
			ingame_swarm.outbreak_level = (byte)outbreak_level.Value;
			ingame_swarm.outbreak_move1 = (ushort)outbreak_move1.SelectedIndex;
			ingame_swarm.outbreak_move2 = (ushort)outbreak_move2.SelectedIndex;
			ingame_swarm.outbreak_move3 = (ushort)outbreak_move3.SelectedIndex;
			ingame_swarm.outbreak_move4 = (ushort)outbreak_move4.SelectedIndex;
		}
		else if (tv_slot.Value != 0m && tv_id.Value == 41m)
		{
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_days_to_tv = (ushort)outbreak_activation.Value;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_map = (ushort)outbreak_map.Value;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_appearance = (byte)outbreak_availability.Value;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_appearance = (byte)outbreak_remaining.Value;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_species = (ushort)outbreak_species.SelectedIndex;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_level = (byte)outbreak_level.Value;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move1 = (ushort)outbreak_move1.SelectedIndex;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move2 = (ushort)outbreak_move2.SelectedIndex;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move3 = (ushort)outbreak_move3.SelectedIndex;
			shows.shows[(int)(tv_slot.Value - 1m)].outbreak_move4 = (ushort)outbreak_move4.SelectedIndex;
		}
		MessageBox.Show("Outbreak Show Updated!");
	}

	private void Tv_statusSelectedIndexChanged(object sender, EventArgs e)
	{
		if (tv_slot.Value == 0m)
		{
			ingame_swarm.status = (byte)tv_status.SelectedIndex;
		}
		else
		{
			shows.shows[(int)(tv_slot.Value - 1m)].status = (byte)tv_status.SelectedIndex;
		}
	}

	private void Tv_tidValueChanged(object sender, EventArgs e)
	{
		if (tv_slot.Value == 0m)
		{
			ingame_swarm.TID_own = (ushort)tv_tid.Value;
		}
		else
		{
			shows.shows[(int)(tv_slot.Value - 1m)].TID_own = (ushort)tv_tid.Value;
		}
	}

	private void Tv_mix_tidValueChanged(object sender, EventArgs e)
	{
		if (tv_slot.Value == 0m)
		{
			ingame_swarm.TID_mixed = (ushort)tv_mix_tid.Value;
		}
		else
		{
			shows.shows[(int)(tv_slot.Value - 1m)].TID_mixed = (ushort)tv_mix_tid.Value;
		}
	}

	private void Tv_idValueChanged(object sender, EventArgs e)
	{
		if (tv_slot.Value == 0m)
		{
			tv_id.Value = ingame_swarm.ID;
		}
		else
		{
			tv_id.Value = shows.shows[(int)(tv_slot.Value - 1m)].ID;
		}
	}

	private void Tv_slotValueChanged(object sender, EventArgs e)
	{
		load_show();
	}

	private void Event_statusSelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Event_idSelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Event_daysValueChanged(object sender, EventArgs e)
	{
	}

	private void Swarm_applyClick(object sender, EventArgs e)
	{
		set_swarm();
	}

	private void Event_applyClick(object sender, EventArgs e)
	{
		set_event();
	}

	
}
