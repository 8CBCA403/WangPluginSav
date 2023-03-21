namespace BW_tool
{
    public partial class DreamRadar : Form
    {
        DRKEY ?drkey;
        DRA? dra;
        DRB? drb;
        int drkeyblock = 72;
        public DreamRadar()
        {
            InitializeComponent();
            if (BWToolMainForm.save != null)
            {         
                drkey = new DRKEY(BWToolMainForm.save.getBlock(drkeyblock));
                dra = new DRA(BWToolMainForm.save.dslinkA_get());
                drb = new DRB(PKX5.cryptoXor32Array(BWToolMainForm.save.dslinkB_get(), 0, 0x7C, 0x7C)); //Get 3DS link data decrypted
                if (dra.received == false)
                {
                    MessageBox.Show("Warning! There's unreceived data in the savegame!");
                    dra.key = drb.EncKey ^ drkey.FLAGS;//This makes editing the data possible without messing up the current encryption
                }

                if (drb.illegal == true)
                {
                    allmode.Checked = true;
                    set_all_list();

                }
                else
                {
                    legitmode.Checked = true;
                    set_legal_list();
                }
                load_data();
            }
        }
        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Saveexit_butClick(object sender, EventArgs e)
        {
            set_data();
            if (BWToolMainForm.save != null&&drkey != null && dra != null && drb != null)
            {
                BWToolMainForm.save.setBlock(drkey.Data, 72);
                BWToolMainForm.save.dslinkA_set(dra.Data);
                BWToolMainForm.save.dslinkB_set(PKX5.cryptoXor32Array(drb.Data, 0, 0x7C, 0x7C));
            }
            this.Close();
        }
        void Clean_butClick(object sender, EventArgs e) //Right now this button is disabled as we know how to edit all the data
        {
            if (drkey != null && dra != null && drb != null)
            {
                drkey.reinit();
                dra.reinit();
                drb.reinit();

                if (BWToolMainForm.save != null)
                {
                    BWToolMainForm.save.setBlock(drkey.Data, 72);
                    BWToolMainForm.save.dslinkA_set(dra.Data);
                    BWToolMainForm.save.dslinkB_set(PKX5.cryptoXor32Array(drb.Data, 0, 0x7C, 0x7C));
                }
            }
            this.Close();
        }

        void set_legal_list()
        {
            pkm1.Items.Clear();
            pkm2.Items.Clear();
            pkm3.Items.Clear();
            pkm4.Items.Clear();
            pkm5.Items.Clear();
            pkm6.Items.Clear();
            pkm1.Items.AddRange(TEXT.drpklist);
            pkm2.Items.AddRange(TEXT.drpklist);
            pkm3.Items.AddRange(TEXT.drpklist);
            pkm4.Items.AddRange(TEXT.drpklist);
            pkm5.Items.AddRange(TEXT.drpklist);
            pkm6.Items.AddRange(TEXT.drpklist);
            item1.Items.Clear();
            item2.Items.Clear();
            item3.Items.Clear();
            item4.Items.Clear();
            item5.Items.Clear();
            item6.Items.Clear();
            item1.Items.AddRange(TEXT.dritemlist);
            item2.Items.AddRange(TEXT.dritemlist);
            item3.Items.AddRange(TEXT.dritemlist);
            item4.Items.AddRange(TEXT.dritemlist);
            item5.Items.AddRange(TEXT.dritemlist);
            item6.Items.AddRange(TEXT.dritemlist);
        }

        void set_all_list()
        {
            pkm1.Items.Clear();
            pkm2.Items.Clear();
            pkm3.Items.Clear();
            pkm4.Items.Clear();
            pkm5.Items.Clear();
            pkm6.Items.Clear();
            pkm1.Items.AddRange(TEXT.pkmlist);
            pkm2.Items.AddRange(TEXT.pkmlist);
            pkm3.Items.AddRange(TEXT.pkmlist);
            pkm4.Items.AddRange(TEXT.pkmlist);
            pkm5.Items.AddRange(TEXT.pkmlist);
            pkm6.Items.AddRange(TEXT.pkmlist);
            item1.Items.Clear();
            item2.Items.Clear();
            item3.Items.Clear();
            item4.Items.Clear();
            item5.Items.Clear();
            item6.Items.Clear();
            item1.Items.AddRange(TEXT.itemlist);
            item2.Items.AddRange(TEXT.itemlist);
            item3.Items.AddRange(TEXT.itemlist);
            item4.Items.AddRange(TEXT.itemlist);
            item5.Items.AddRange(TEXT.itemlist);
            item6.Items.AddRange(TEXT.itemlist);
        }
        int poke2legit(int species)
        {
            if (legitmode.Checked == true&&drb!=null)
            {
                int i = 0;
                for (i = 0; i < 19; i++)
                {
                    if (species == drb.legit_pk_index[i])
                        return i;
                }
            }
            return species;
        }
        int item2legit(int item)
        {
            if (legitmode.Checked == true && drb != null)
            {
                int i = 0;
                for (i = 0; i < 24; i++)
                {
                    if (item == drb.legit_item_index[i])
                        return i;
                }
            }
            return item;
        }
        void load_data()
        {
            if (drkey != null && dra != null && drb != null)
            {
                pkm1.SelectedIndex = poke2legit(drb.get_poke_species(0));
                pkm2.SelectedIndex = poke2legit(drb.get_poke_species(1));
                pkm3.SelectedIndex = poke2legit(drb.get_poke_species(2));
                pkm4.SelectedIndex = poke2legit(drb.get_poke_species(3));
                pkm5.SelectedIndex = poke2legit(drb.get_poke_species(4));
                pkm6.SelectedIndex = poke2legit(drb.get_poke_species(5));

                item1.SelectedIndex = item2legit(drb.get_item_id(0));
                item2.SelectedIndex = item2legit(drb.get_item_id(1));
                item3.SelectedIndex = item2legit(drb.get_item_id(2));
                item4.SelectedIndex = item2legit(drb.get_item_id(3));
                item5.SelectedIndex = item2legit(drb.get_item_id(4));
                item6.SelectedIndex = item2legit(drb.get_item_id(5));

                pkmgnd1.SelectedIndex = drb.get_poke_gender(0);
                pkmgnd2.SelectedIndex = drb.get_poke_gender(1);
                pkmgnd3.SelectedIndex = drb.get_poke_gender(2);
                pkmgnd4.SelectedIndex = drb.get_poke_gender(3);
                pkmgnd5.SelectedIndex = drb.get_poke_gender(4);
                pkmgnd6.SelectedIndex = drb.get_poke_gender(5);

                itemcnt1.Value = drb.get_item_amount(0);
                itemcnt2.Value = drb.get_item_amount(1);
                itemcnt3.Value = drb.get_item_amount(2);
                itemcnt4.Value = drb.get_item_amount(3);
                itemcnt5.Value = drb.get_item_amount(4);
                itemcnt6.Value = drb.get_item_amount(5);

                legend1.SelectedIndex = drb.get_legend(0);
                legend2.SelectedIndex = drb.get_legend(1);
                legend3.SelectedIndex = drb.get_legend(2);
                legend4.SelectedIndex = drb.get_legend(3);
                legend5.SelectedIndex = drb.get_legend(4);
                legend6.SelectedIndex = drb.get_legend(5);
                legend7.SelectedIndex = drb.get_legend(6);
                legend8.SelectedIndex = drb.get_legend(7);

                flag0.Checked = drkey.Tornadus;
                flag1.Checked = drkey.Thundurus;
                flag2.Checked = drkey.Landorus;
                flag3.Checked = drkey.Dialga;
                flag4.Checked = drkey.Palkia;
                flag5.Checked = drkey.Giratina;
                flag6.Checked = drkey.HoOh;
                flag7.Checked = drkey.Lugia;
            }
        }

        void set_data()
        {
            if (drkey != null && dra != null && drb != null)
            //Get the correct intial key before changing the flags
            {
                drb.EncKey = dra.key ^ drkey.FLAGS;

                //Set the flags
                drkey.Tornadus = flag0.Checked;
                drkey.Thundurus = flag1.Checked;
                drkey.Landorus = flag2.Checked;
                drkey.Dialga = flag3.Checked;
                drkey.Palkia = flag4.Checked;
                drkey.Giratina = flag5.Checked;
                drkey.HoOh = flag6.Checked;
                drkey.Lugia = flag7.Checked;

                drb.clean_data();//Set everything to 0 first
                                 //Legendary slots
                switch (legend1.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 0);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 0);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 0);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 0);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 0);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 0);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 0);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 0);
                        break;
                    default:
                        drb.set_legend(0, 0);
                        break;
                };
                switch (legend2.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 1);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 1);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 1);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 1);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 1);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 1);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 1);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 1);
                        break;
                    default:
                        drb.set_legend(0, 1);
                        break;
                };
                switch (legend3.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 2);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 2);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 2);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 2);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 2);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 2);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 2);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 2);
                        break;
                    default:
                        drb.set_legend(0, 2);
                        break;
                };
                switch (legend4.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 3);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 3);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 3);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 3);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 3);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 3);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 3);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 3);
                        break;
                    default:
                        drb.set_legend(0, 3);
                        break;
                };
                switch (legend5.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 4);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 4);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 4);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 4);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 4);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 4);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 4);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 4);
                        break;
                    default:
                        drb.set_legend(0, 4);
                        break;
                };
                switch (legend6.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 5);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 5);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 5);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 5);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 5);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 5);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 5);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 5);
                        break;
                    default:
                        drb.set_legend(0, 5);
                        break;
                };
                switch (legend7.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 6);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 6);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 6);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 6);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 6);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 6);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 6);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 6);
                        break;
                    default:
                        drb.set_legend(0, 6);
                        break;
                };
                switch (legend8.SelectedIndex)
                {
                    case 1:
                        drb.set_legend(DRB.Tornadus, 7);
                        break;
                    case 2:
                        drb.set_legend(DRB.Thundurus, 7);
                        break;
                    case 3:
                        drb.set_legend(DRB.Landorus, 7);
                        break;
                    case 4:
                        drb.set_legend(DRB.Dialga, 7);
                        break;
                    case 5:
                        drb.set_legend(DRB.Palkia, 7);
                        break;
                    case 6:
                        drb.set_legend(DRB.Giratina, 7);
                        break;
                    case 7:
                        drb.set_legend(DRB.HoOh, 7);
                        break;
                    case 8:
                        drb.set_legend(DRB.Lugia, 7);
                        break;
                    default:
                        drb.set_legend(0, 7);
                        break;
                };
                if (legitmode.Checked == true)
                {
                    drb.set_poke(drb.legit_pk_index[pkm1.SelectedIndex], pkmgnd1.SelectedIndex, 0);
                    drb.set_poke(drb.legit_pk_index[pkm2.SelectedIndex], pkmgnd2.SelectedIndex, 1);
                    drb.set_poke(drb.legit_pk_index[pkm3.SelectedIndex], pkmgnd3.SelectedIndex, 2);
                    drb.set_poke(drb.legit_pk_index[pkm4.SelectedIndex], pkmgnd4.SelectedIndex, 3);
                    drb.set_poke(drb.legit_pk_index[pkm5.SelectedIndex], pkmgnd5.SelectedIndex, 4);
                    drb.set_poke(drb.legit_pk_index[pkm6.SelectedIndex], pkmgnd6.SelectedIndex, 5);

                    drb.set_item((int)itemcnt1.Value, drb.legit_item_index[item1.SelectedIndex], 0);
                    drb.set_item((int)itemcnt2.Value, drb.legit_item_index[item2.SelectedIndex], 1);
                    drb.set_item((int)itemcnt3.Value, drb.legit_item_index[item3.SelectedIndex], 2);
                    drb.set_item((int)itemcnt4.Value, drb.legit_item_index[item4.SelectedIndex], 3);
                    drb.set_item((int)itemcnt5.Value, drb.legit_item_index[item5.SelectedIndex], 4);
                    drb.set_item((int)itemcnt6.Value, drb.legit_item_index[item6.SelectedIndex], 5);
                }
                else
                {
                    drb.set_poke(pkm1.SelectedIndex, pkmgnd1.SelectedIndex, 0);
                    drb.set_poke(pkm2.SelectedIndex, pkmgnd2.SelectedIndex, 1);
                    drb.set_poke(pkm3.SelectedIndex, pkmgnd3.SelectedIndex, 2);
                    drb.set_poke(pkm4.SelectedIndex, pkmgnd4.SelectedIndex, 3);
                    drb.set_poke(pkm5.SelectedIndex, pkmgnd5.SelectedIndex, 4);
                    drb.set_poke(pkm6.SelectedIndex, pkmgnd6.SelectedIndex, 5);

                    drb.set_item((int)itemcnt1.Value, item1.SelectedIndex, 0);
                    drb.set_item((int)itemcnt2.Value, item2.SelectedIndex, 1);
                    drb.set_item((int)itemcnt3.Value, item3.SelectedIndex, 2);
                    drb.set_item((int)itemcnt4.Value, item4.SelectedIndex, 3);
                    drb.set_item((int)itemcnt5.Value, item5.SelectedIndex, 4);
                    drb.set_item((int)itemcnt6.Value, item6.SelectedIndex, 5);
                }

                int i = 0;
                for (i = 0; i < drb.Size; i++)
                {
                    if (drb.Data[i] != 0)
                        dra.received = false; //If we have any data, mark as available to be received
                }

                //This is what Dream Radar does, not doing this makes the data be recognized as corrupted.
                dra.unknown1 = 0;
                dra.key = 0;
            }

        }
        void AllmodeCheckedChanged(object sender, EventArgs e)
        {
            if (allmode.Checked == true)
            {
                set_all_list();

            }
            else
            {
                set_legal_list();
            }

            load_data();
        }
        void LegitmodeCheckedChanged(object sender, EventArgs e)
        {
            if (allmode.Checked == true)
            {
                set_all_list();

            }
            else
            {
                set_legal_list();
            }

            load_data();
        }
        void Flag0CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}

//3DS Link structure research by BlackShark: https://projectpokemon.org/forums/forums/topic/40323-white-2-dream-radar-flags/

/*
Save Offset  0x25E00
0x00  unknown (changes when the data is received)
0x04  legendary received flags
0x08  1 after DR data was received the first time, does not increase

Legendary received flags
Bit Pokemon
0   Tornadus
1   Thundurus
2   Landorus
3   Dialga
4   Palkia
5   Giratina
6   Ho-Oh
7   Lugia
======================================================================
 
Save Offset  0x7F000 (the Dream Radar itself only touches this area!)
 
0x00         received/not received flag (1 after the Pokemon were received)
0x01 - 0x03  0x000000
0x04 - 0x07  unknown (derived from offset 0x25E00) (0x00000000 if the Pokemon were not yet received)
0x08 - 0x0B  always 0x43524746 (CRGF)
0x0C - 0x0F  Encryption Key used for the next transfer from DR (0x00000000 if the Pokemon were not yet received) --> Also seems to hold the lengedary flags!
0x10 - 0x11  CRC-16-CCITT over 0x00 - 0x0F
0x12 - 0x13  0x0000
0x14 - 0x33  legendary Pokemon (see values below) (8 x 4 Bytes)
0x34 - 0x4B  normal Pokemon (6 x 4 Bytes)
0x4C - 0x63  Items (6 x 4 Bytes)
0x63 - 0x8F  probably unused (all zero)
0x90 - 0x93  Decryption Key
0x94 - 0x95  CRC-16-CCITT over 0x14 - 0x93
0x96 - 0x97  0x0000

Legendary Pokemon Values
0x80808080  Tornadus
0x92567284  Thundurus
0x87643567  Landorus
0x96436763  Dialga
0x43867368  Palkia
0x17693572  Giratina
0x44798367  Ho-Oh
0x96636983  Lugia
 
Pokemon Structure
0x00         Gender (0 - Male, 1 - Female, 2 - Genderless)
0x01         unknown/unused
0x02 - 0x03  Species ID
 
Item Structure
0x00 - 0x01  Quantity
0x02 - 0x03  Item ID

*/