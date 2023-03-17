//Base file from kaphotic's pkhex

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BW_tool
{
	public class Crypto
    {
        public int start;
        public int length;
        public int seed;      
    }
	public class BlockInfo
    {
        public int Offset;
        public int Length;
        public int ID;
        public int updtcnt;
        public int Checksum;
        public bool encrypted;
        public Crypto crypto;       
    }
	public class SAV5 : PKX5
    {
		private int DEBUG_MSG = 0;
		//
		// 0: no checksum updated/not updated msg
		// 1: only checksum updated msg
		// 2: checksum updated and not updated msg
		
    	private static int[] BlockTableBW2 =
		{0x00000, 0x00400, 0x01400, 0x02400, 0x03400, 0x04400, 0x05400, //6
		 0x06400, 0x07400, 0x08400, 0x09400, 0x0A400, 0x0B400, 0x0C400, //13
		 0x0D400, 0x0E400, 0x0F400, 0x10400, 0x11400, 0x12400, 0x13400, //20
		 0x14400, 0x15400, 0x16400, 0x17400, 0x18400, 0x18E00, 0x19400, //27
		 0x19500, 0x19600, 0x1AA00, 0x1B200, 0x1C000, 0x1C100, 0x1C800, //34
		 0x1D300, 0x1D500, 0x1D900, 0x1DA00, 0x1DC00, 0x1DD00, 0x1E200, //41
		 0x1F700, 0x1FA00, 0x1FB00, 0x1FF00, 0x20400, 0x20500, 0x20800, //48
		 0x20900, 0x20D00, 0x20F00, 0x21100, 0x21200, 0x21400, 0x21900, //55
		 0x21A00, 0x21B00, 0x21D00, 0x22900, 0x22A00, 0x23300, 0x23600, //62
		 0x23700, 0x23800, 0x23A00, 0x23B00, 0x23C00, 0x25300, 0x25800, //69
		 0x25900, 0x25A00, 0x25E00, 0x25F00}; //73
	
    	private static int[] BlockTableLengthBW2 =
		{0x3E0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //6
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //13
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //20
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0x9EC, 0X534, 0xB0, //27
		 0xA8, 0x1338, 0x7C4, 0xD54, 0X94, 0x658, 0xA94, //34
		 0x1AC, 0x3EC, 0x5C, 0x1E0, 0xA8, 0x460, 0x1400, //41
		 0x2A4, 0xE0, 0x34C, 0x4E0, 0xF8, 0x2FC, 0x94, //48
		 0x35C, 0x1D4, 0x1E0, 0xF0, 0x1B4, 0x4DC, 0x34, //55
		 0X3C, 0x1AC, 0xB90, 0xAC, 0x850, 0x284, 0x10, //62
		 0xA8, 0x16C, 0x80, 0xFC, 0x16A8, 0x498, 0x60, //69
		 0xFC, 0x3E4, 0xF0, 0x94}; //73

    	private static int CrcTableBW2 = 73;
    	
    	private static int[] BlockTableBW =
		{0x00000, 0x00400, 0x01400, 0x02400, 0x03400, 0x04400, 0x05400, //6
		 0x06400, 0x07400, 0x08400, 0x09400, 0x0A400, 0x0B400, 0x0C400, //13
		 0x0D400, 0x0E400, 0x0F400, 0x10400, 0x11400, 0x12400, 0x13400, //20
		 0x14400, 0x15400, 0x16400, 0x17400, 0x18400, 0x18E00, 0x19400, //27
		 0x19500, 0x19600, 0x1AA00, 0x1B200, 0x1C000, 0x1C100, 0x1C800, //34
		 0x1D300, 0x1D500, 0x1D900, 0x1DA00, 0x1DC00, 0x1DD00, 0x1E200, //41
		 0x1F700, 0x1FA00, 0x1FD00, 0x20100, 0x20500, 0x20600, 0x20900, //48
		 0x20A00, 0x20E00, 0x21000, 0x21200, 0x21300, 0x21500, 0x21600, //55
		 0x21B00, 0x21C00, 0x21D00, 0x21F00, 0x22B00, 0x22C00, 0x23500, //62
		 0x23600, 0x23900, 0x23A00, 0x23B00, 0x23D00, 0x23E00, 0x23F00}; //69
    	
    	private static int[] BlockTableLengthBW =
		{0x3E0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //6
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //13
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0xFF0, //20
		 0xFF0, 0xFF0, 0xFF0, 0xFF0, 0x9C0, 0X534, 0x68, //27
		 0x9C, 0x1338, 0x7C4, 0xD54, 0X2C, 0x658, 0xA94, //34
		 0x1AC, 0x3EC, 0x5C, 0x1E0, 0xA8, 0x460, 0x1400, //41
		 0x2A4, 0x2DC, 0x34C, 0x3EC, 0xF8, 0x2FC, 0x94, //48
		 0x35C, 0x1CC, 0x168, 0xEC, 0x1B0, 0x1C, 0x4D4, //55
		 0X34, 0x3C, 0x1AC, 0xB90, 0x9C, 0x850, 0x28, //62
		 0x284, 0x10, 0x5C, 0x16C, 0x40, 0xFC, 0x8C}; //69
    	
    	private static int CrcTableBW = 69;
    	
        internal const int SIZERAW = 0x80000; // 512KB
        internal const int SIZE1 = 0x24000; // B/W
        internal const int SIZE2 = 0x26000; // B2/W2

        // Global Settings
        // Save Data Attributes
        public byte[] Data;
        public bool Edited;
        public readonly bool Exportable;
        public readonly byte[] BAK;
        public string FileName, FilePath;
        public BlockInfo[] blocks = new BlockInfo[74];
        public bool B2W2;
        public bool BW;
        public SAV5(byte[] data)
        {
            Data = (byte[])(data ?? new byte[SIZERAW]).Clone();
            BAK = (byte[])Data.Clone();
            Exportable = !Data.SequenceEqual(new byte[Data.Length]);

            // Get Version
            // Validate Checksum over the Checksum Block to find BW or B2W2
            ushort chk2 = BitConverter.ToUInt16(Data, SIZE2 - 0x100 + 0x94 + 0xE);
            ushort actual2 = ccitt16(Data.Skip(SIZE2 - 0x100).Take(0x94).ToArray());
            B2W2 = chk2 == actual2;
            ushort chk1 = BitConverter.ToUInt16(Data, SIZE1 - 0x100 + 0x8C + 0xE);
            ushort actual1 = ccitt16(Data.Skip(SIZE1 - 0x100).Take(0x8C).ToArray());
            BW = chk1 == actual1;
			          
            if (!BW && !B2W2 && data != null){
                Data = null; // Invalid/Not G5 Save File
            }else if (B2W2)
            {
	
	           //Build blockinfos
	           int i;
	           for (i=0;i<=CrcTableBW2;i++)
	           {
	           		blocks[i] = new BlockInfo();
	           		blocks[i].crypto = new Crypto();
		           	blocks[i].Offset=BlockTableBW2[i];
	           		blocks[i].Length=BlockTableLengthBW2[i];
	           		blocks[i].ID= i;
	           		blocks[i].updtcnt=blocks[i].Offset+blocks[i].Length;
	           		if (i != 73)
	           		{
	           			blocks[i].Checksum=blocks[i].Offset+blocks[i].Length+2;
	           		}
	           		else
	           		{
	           			blocks[i].Checksum=0x25FA2;
	           		}
	           		switch (i)
	           		{
	           			case 34: //Wondercards
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x00;
	           				blocks[i].crypto.length = 0xA90;
	           				blocks[i].crypto.seed = 0xA90;
	           				break;
	           			case 38: //Trainer card records
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x04;
	           				blocks[i].crypto.length = 0x1DC;
	           				blocks[i].crypto.seed = 0x1DC;
	           				break;
	           			case 60: //Entralink forest
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x00;
	           				blocks[i].crypto.length = 0x84C;
	           				blocks[i].crypto.seed = 0x84C;
	           				break;
	           			default:
	           				blocks[i].encrypted=false;
	           				break;
	           		}	           	
	           }
            }
            else if (BW)
            {
	           //Build blockinfos
	           int i;
	           for (i=0;i<=CrcTableBW;i++)
	           {
	           		blocks[i] = new BlockInfo();
	           		blocks[i].crypto = new Crypto();
		           	blocks[i].Offset=BlockTableBW[i];
	           		blocks[i].Length=BlockTableLengthBW[i];
	           		blocks[i].ID= i;
	           		blocks[i].updtcnt=blocks[i].Offset+blocks[i].Length;
	           		if (i != CrcTableBW)
	           		{
	           			blocks[i].Checksum=blocks[i].Offset+blocks[i].Length+2;
	           		}
	           		else if (i == CrcTableBW)
	           		{
	           			blocks[i].Checksum=0x23F9A;
	           		}
	           		switch (i)
	           		{
	           			/*case 34: //Wondercards
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x00;
	           				blocks[i].crypto.length = 0xA90;
	           				blocks[i].crypto.seed = 0xA90;
	           				break;
	           			*/
	           			case 38: //Trainer card records
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x04;
	           				blocks[i].crypto.length = 0x1DC;
	           				blocks[i].crypto.seed = 0x1DC;
	           				break;
	           			case 61: //Entralink forest
	           				blocks[i].encrypted=true;
	           				blocks[i].crypto.start = 0x00;
	           				blocks[i].crypto.length = 0x84C;
	           				blocks[i].crypto.seed = 0x84C;
	           				break;
	           			default:
	           				blocks[i].encrypted=false;
	           				break;
	           		}	           	
	           }
            }
           	// Different Offsets for different games.
	        BattleBox = B2W2 ? 0x20A00 : 0x20900;
        }

        private const int Box = 0x400;
        private const int Party = 0x18E00;
        private readonly int BattleBox;
        private const int Trainer = 0x19400;
        private const int Wondercard = 0x1C800;
        private const int wcSeed = 0x1D290;

        public byte[] getData(int Offset, int Length)
        {
            return Data.Skip(Offset).Take(Length).ToArray();
        }
        public byte[] getBlock(int index)
        {
        	int blocksnum = 0;
        	int backupoffset = 0;
        	if (B2W2)
        	{
        		blocksnum = CrcTableBW2;
        		backupoffset = SIZE2;
        	}
        	else if (BW)
        	{
        		blocksnum = CrcTableBW;
        		backupoffset = SIZE1;
        	}
        	else return null;

			if (index < blocksnum)
			{
				return Data.Skip(blocks[index].Offset).Take(blocks[index + 1].Offset - blocks[index].Offset).ToArray();
			} 
			else if (index == blocksnum)
			{
				return Data.Skip(blocks[index].Offset).Take(backupoffset - blocks[index].Offset).ToArray();
			} 
			else
				return null;
        }
        public byte[] getBlockDec(int index)
        {
        	byte[] decrypt = new byte[getBlockLength(index)];

        	int blocksnum = 0;
        	int backupoffset = 0;
        	if (B2W2)
        	{
        		blocksnum = CrcTableBW2;
        		backupoffset = SIZE2;
        	}
        	else if (BW)
        	{
        		blocksnum = CrcTableBW;
        		backupoffset = SIZE1;
        	}
        	else return null;
        	
			if (index < blocksnum) {
				//MessageBox.Show(decrypt.Length.ToString());
				//MessageBox.Show((blocks[index].Length-4).ToString());
				decrypt = PKX5.cryptoArray(Data.Skip(blocks[index].Offset).Take(blocks[index + 1].Offset - blocks[index].Offset).ToArray(), blocks[index].crypto.start, blocks[index].crypto.length, blocks[index].crypto.seed);
				//MessageBox.Show((blocks[index].Length-4).ToString());
				return decrypt;
			} else if (index == 73) {
				return Data.Skip(blocks[index].Offset).Take(backupoffset - blocks[index].Offset).ToArray();
			} else
				return null;
        }
        public int getBlockLength(int index)
        {
        	int blocksnum = 0;
        	int backupoffset = 0;
        	if (B2W2)
        	{
        		blocksnum = CrcTableBW2;
        		backupoffset = SIZE2;
        	}
        	else if (BW)
        	{
        		blocksnum = CrcTableBW;
        		backupoffset = SIZE1;
        	}
        	else return -1;
        	
        	//Get size
			if (index < blocksnum)
				return blocks[index + 1].Offset - blocks[index].Offset;
			else if (index == blocksnum)
				return backupoffset - blocks[index].Offset;
			else
				return -1;

        }
        public void setBlock(byte[] input, int index)
        {
        	if (getBlockLength(index) != input.Length)
        	{
        		MessageBox.Show("Block " + index.ToString() + " has invalid size!");
        		return;
        	}
        	        	
        	int blocksnum = 0;
        	int backupoffset = 0;
        	if (B2W2)
        	{
        		blocksnum = CrcTableBW2;
        		backupoffset = SIZE2;
        	}
        	else if (BW)
        	{
        		blocksnum = CrcTableBW;
        		backupoffset = SIZE1;
        	}
        	else
        	{
        		MessageBox.Show("Invalid file");
        		return;
        	}
 			
			if (index <= blocksnum)
			{
				//Recalculate checksum before applying to savedata
				ushort crc = ccitt16(input.Take(blocks[index].Length).ToArray());
				ushort crcintable = BitConverter.ToUInt16(Data, ((blocks[blocksnum].Offset) + (index * 2)));
				if (crc != BitConverter.ToUInt16(input, blocks[index].Checksum - blocks[index].Offset) || crc!=crcintable) {
					Array.Copy(BitConverter.GetBytes(crc), 0, input, blocks[index].Checksum - blocks[index].Offset, 2);
					//Update CRC tables
					Array.Copy(BitConverter.GetBytes(crc), 0, Data, ((blocks[blocksnum].Offset) + (index * 2)), 2);
					Array.Copy(BitConverter.GetBytes(crc), 0, Data, ((blocks[blocksnum].Offset) + (index * 2) + backupoffset), 2);
					//recalculate crc table's checksum
					ushort crctable = ccitt16(Data.Skip(blocks[blocksnum].Offset).Take(((blocksnum + 1) * 2)).ToArray());
					Array.Copy(BitConverter.GetBytes(crctable), 0, Data, blocks[blocksnum].Checksum, 2);
					Array.Copy(BitConverter.GetBytes(crctable), 0, Data, blocks[blocksnum].Checksum + backupoffset, 2);
					if (DEBUG_MSG  > 0) MessageBox.Show("Block " + index.ToString() + " checksum updated");
				} else {
					if (DEBUG_MSG  > 2) MessageBox.Show("Checksum " + index.ToString() + " doesn't need update");
				}
      			
				input.CopyTo(Data, blocks[index].Offset);
				input.CopyTo(Data, blocks[index].Offset + backupoffset);
				Edited = true;
			}
			else
			{
				MessageBox.Show("Invalid index (" + index.ToString() + ")");
        		return;
			}
        }
		public void setBlockCrypt(byte[] input, int index)
        {
   			//Encrypt
   			byte[] encrypt = new byte[getBlockLength(index)];
   			encrypt = PKX5.cryptoArray(input, blocks[index].crypto.start, blocks[index].crypto.length, blocks[index].crypto.seed);
   			setBlock(encrypt, index);
        }
        public void setData(byte[] input, int Offset)
        {
            input.CopyTo(Data, Offset);
            Edited = true;
        }
        public void chkCheck(bool correct)
        {
        	int i = 0;
        	string badblocks;
        	badblocks = "Found bad checksums in MAIN save at blocks: ";
        	string correctedblocks;
        	correctedblocks = "Corrected checksums in MAIN save at blocks: ";
        	bool badcheck = false;
        	bool firstcorrect = false;
        	
        	int blocksnum = 0;
        	int backupoffset = 0;
        	
        	if (B2W2)
        	{
        		blocksnum = CrcTableBW2;
        		backupoffset = SIZE2;
        	}
        	else if (BW)
        	{
        		blocksnum = CrcTableBW;
        		backupoffset = SIZE1;
        	}
        	else
        	{
        		MessageBox.Show("Invalid file");
        		return;
        	}
        	
			//Main save checksums
			for (i = 0; i <= blocksnum; i++) {
				ushort crc = ccitt16(Data.Skip(blocks[i].Offset).Take(blocks[i].Length).ToArray());
				if (crc != BitConverter.ToUInt16(Data, blocks[i].Checksum)) {
					if (correct) {
						Array.Copy(BitConverter.GetBytes(crc), 0, Data, blocks[i].Checksum, 2);
						//Update CRC tables
						Array.Copy(BitConverter.GetBytes(crc), 0, Data, ((blocks[blocksnum].Offset) + (i * 2)), 2);
						//recalculate crc table's checksum
						ushort crctable = ccitt16(Data.Skip(blocks[blocksnum].Offset).Take(((blocksnum + 1) * 2)).ToArray());
						Array.Copy(BitConverter.GetBytes(crctable), 0, Data, blocks[blocksnum].Checksum, 2);
						
						if (!firstcorrect) {
							firstcorrect = true;
							correctedblocks = correctedblocks + i.ToString();
						} else {
							correctedblocks = correctedblocks + ", " + i.ToString();
						}
						Edited = true;
					}
					//Build bad checksum message
					if (!badcheck) {
						badcheck = true;
						badblocks = badblocks + i.ToString();
					} else {
						badblocks = badblocks + ", " + i.ToString();
					}
				} else {
					//MessageBox.Show("Checksum doesn't need update " + i.ToString());
				}
			}
        		
			if (badcheck) {
				if (correct)
					MessageBox.Show(correctedblocks);
				else
					MessageBox.Show(badblocks);
			} else
				MessageBox.Show("All checksums OK in MAIN save");

			//Backup save checksums
			badcheck = false;
			badblocks = "Found bad checksums in BACKUP save at blocks: ";
			firstcorrect = false;
			correctedblocks = "Corrected checksums in BACKUP save at blocks: ";
			for (i = 0; i <= blocksnum; i++) {
				ushort crc = ccitt16(Data.Skip(blocks[i].Offset + backupoffset).Take(blocks[i].Length).ToArray());
				if (crc != BitConverter.ToUInt16(Data, blocks[i].Checksum + backupoffset)) {
					if (correct) {
						Array.Copy(BitConverter.GetBytes(crc), 0, Data, blocks[i].Checksum + backupoffset, 2);
						//Update CRC tables
						Array.Copy(BitConverter.GetBytes(crc), 0, Data, ((blocks[blocksnum].Offset) + (i * 2) + backupoffset), 2);
						//recalculate crc table's checksum
						ushort crctable = ccitt16(Data.Skip(blocks[blocksnum].Offset + backupoffset).Take(((blocksnum + 1) * 2)).ToArray());
						Array.Copy(BitConverter.GetBytes(crctable), 0, Data, blocks[blocksnum].Checksum + backupoffset, 2);
						
						if (!firstcorrect) {
							firstcorrect = true;
							correctedblocks = correctedblocks + i.ToString();
						} else {
							correctedblocks = correctedblocks + ", " + i.ToString();
						}
						Edited = true;
					}
					//Build bad checksum message
					if (!badcheck) {
						badcheck = true;
						badblocks = badblocks + i.ToString();
					} else {
						badblocks = badblocks + ", " + i.ToString();
					}
				} else {
					//MessageBox.Show("Checksum doesn't need update " + i.ToString());
				}
			}
        		
			if (badcheck) {
				if (correct)
					MessageBox.Show(correctedblocks);
				else
					MessageBox.Show(badblocks);
			} else
				MessageBox.Show("All checksums OK in BACKUP save");
        		
			return;
        }
        //Updates both MAIN and BACKUP crc (editor updates both MAIN and BACKUP when using setBlock)
        public void block_crc_recalc(int index)
        {
        	setBlock(getBlock(index), index);
        }
        
        public byte[] pokedex_skin_get()
        {
        	if (B2W2 == true){
	        	return getData(0x6D800, 0x6200);
        	}else{
        		;
        	}
        	return null;
        }
        public void pokedex_skin_set(byte[] skin)
        {
        	byte[] skin2 = new byte[0x6204];
        	skin.CopyTo(skin2, 0);
        	skin2[6200] = 0xFF;
        	skin2[6201] = 0xFF;
        	skin2[6202] = 0xFF;
        	skin2[6203] = 0xFF;
			if (B2W2 == true)
			{
				setData(skin2, 0x6D800);
				//Set update counter if there's none already
				if (BitConverter.ToUInt16(getData(0x6D800+0x6204,2), 0) == 0){
					UInt16 counter = 0x0001;
					setData(BitConverter.GetBytes(counter), 0x6D800+0x6204);
				}
				//Fix checksum
				ushort crc = ccitt16(skin2);
				setData(BitConverter.GetBytes(crc), 0x73A06);
				
				//Add extra mirror data
				setData(BitConverter.GetBytes(crc), 0x73B00);//Mirror
			}
        	else
        	{
        		;
        	}
        }
        public byte[] cgear_skin_get()
        {
        	if (B2W2 == true){
	        	return getData(0x52800, 0x2600);
        	}else{
        		;
        	}
        	return null;
        }
        public void cgear_skin_set(byte[] cgear)
        {
			if (B2W2 == true)
			{
				setData(cgear, 0x52800);
				//Set update counter if there's none already
				if (BitConverter.ToUInt16(getData(0x52800+0x2600,2), 0) == 0){
					UInt16 counter = 0x0001;
					setData(BitConverter.GetBytes(counter), 0x52800+0x2600);
				}
				//Fix checksum
				ushort crc = ccitt16(cgear);
				setData(BitConverter.GetBytes(crc), 0x54E02);
				
				//Add extra mirror data
				setData(BitConverter.GetBytes(crc), 0x54F00);//Mirror

			}
        	else
        	{
        		;
        	}
        }
        public byte[] musical_get()
        {
        	byte[] pms = new byte[0x17D78];
        	if (B2W2 == true){
        		getData(0x55800, 0x17D14).CopyTo(pms, 0);
        		getData(0x1f908, 0x64).CopyTo(pms, 0x17D14);
        	}else{
        		;
        	}
        	return pms;
        }
        public void musical_set(byte[] musical)
        {
			if (B2W2 == true)
			{
				setData(musical.Take(0x17D14).ToArray(), 0x6D800);
				//Set musical data to block 42 and Fix checksum #42
				setData(musical.Skip(0x17D14).Take(0x64).ToArray(), 0x1F908);
				block_crc_recalc(42);
			}
        	else
        	{
        		;
        	}
        }
        public byte[] pwt_get(int index)
        {
        	if (B2W2 == true){
	        	return getData(0, 0x1314);
        	}else{
        		;
        	} 
        	return null;
        }
        public void pwt_set(int index, byte[] pwt)
        {
			if (B2W2 == true)
			{
				setData(pwt, 0x1314);
				//Fix checksum
				ushort crc = ccitt16(pwt);
				setData(BitConverter.GetBytes(crc), 0x73A06);
				setData(BitConverter.GetBytes(crc), 0x73B00);//Mirror
			}
        	else
        	{
        		;
        	}
        }
        
        public byte[] dslinkA_get()
        {
        	if (B2W2 == true){
	        	return getData(0x7F000, 0x10);
        	}else{
        		;
        	} 
        	return null;
        }
        public void dslinkA_set(byte[] dslinkA)
        {
			if (B2W2 == true)
			{
				setData(dslinkA, 0x7F000);
				//Fix checksum
				ushort crc = ccitt16(dslinkA);
				setData(BitConverter.GetBytes(crc), 0x7F010);
				//Just to be sure this is set 0xFFFF (seems basically unused though)
				Data[0x7F012] = 0xFF;
				Data[0x7F013] = 0xFF;
			}
        }
        public byte[] dslinkB_get()
        {
        	if (B2W2 == true){
	        	return getData(0x7F014, 0x80);
        	}else{
        		;
        	} 
        	return null;
        	
        }
        public void dslinkB_set(byte[] dslinkB)
        {
			if (B2W2 == true)
			{
				setData(dslinkB, 0x7F014);
				//Fix checksum
				ushort crc = ccitt16(dslinkB);
				setData(BitConverter.GetBytes(crc), 0x7F094);
			}
        }
    }
}