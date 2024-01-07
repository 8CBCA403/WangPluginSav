/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/03/2016
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/* Data shown in trainer card info
 * 
Times Linked
Link Battles
Link Battle Wins
Link Battle Losses
Link Trades
Wild Pokémon encounters
Trainers Battled
Feeling checks


----Not on trainer records

People passed by
Usable Pass Powers
Musical Performances ? - Appears if not 0
Poké Transfer High Score ? - Appears if not 0
Battle Test High Score ? - Appears if not 0
Cleared Funfest missions
Movie Shoots ? - Appears if not 0
Wins at the PWT
Customers recommended to Join Avenue ? - Appears if not 0
*/

namespace BW_tool
{
    /// <summary>
    /// Description of TrainerRec.
    /// </summary>
    public partial class TrainerRec : Form
    {
        TR trainerrecords;
        public TrainerRec()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            if (BWToolMainForm.save.B2W2)
            {
                trainerrecords = new TR(BWToolMainForm.save.getBlockDec(38));
            }
            else
            {
                trainerrecords = new TR(BWToolMainForm.save.getBlockDec(38));
            }
            record_index.SelectedIndex = 0;
            record_value.Value = trainerrecords.WildCount;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        public class TR
        {
            internal int Size = BWToolMainForm.save.B2W2 ? BWToolMainForm.save.getBlockLength(38) : BWToolMainForm.save.getBlockLength(38); //Update with BW 1

            public byte[] Data;
            public TR(byte[] data = null)
            {
                Data = data ?? new byte[Size];
            }

            // General Card Properties
            public uint WildCount
            {
                get { return BitConverter.ToUInt32(Data, 0x14); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x14); }
            }
            public uint TrBattles
            {
                get { return BitConverter.ToUInt32(Data, 0x18); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x18); }
            }
            public UInt16 Feelings
            {
                get { return BitConverter.ToUInt16(Data, 0x170); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x170); }
            }
            public UInt16 Musical
            {
                get { return BitConverter.ToUInt16(Data, 0x172); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x172); }
            }
            public UInt16 BattleTest
            {
                get { return BitConverter.ToUInt16(Data, 0x186); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x186); }
            }
            public UInt16 MovieShoots
            {
                get { return BitConverter.ToUInt16(Data, 0x194); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x194); }
            }
            public UInt16 Customers
            {
                get { return BitConverter.ToUInt16(Data, 0x18C); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x18C); }
            }
            public UInt16 BattleWins
            {
                get { return BitConverter.ToUInt16(Data, 0x120); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x120); }
            }
            public UInt16 BattleLoses
            {
                get { return BitConverter.ToUInt16(Data, 0x4C); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x4C); }
            }
        }


        void Record_indexSelectedIndexChanged(object sender, EventArgs e)
        {
            record_value.Value = trainerrecords.WildCount;
        }
    }
}
