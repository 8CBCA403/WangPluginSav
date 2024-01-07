/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 02/03/2016
 * Time: 8:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
    /// <summary>
    /// Description of FileIO.
    /// </summary>
    public class FileIO
    {
        /// <summary>
        /// Reads data into a complete array, throwing an EndOfStreamException
        /// if the stream runs out of data first, or if an IOException
        /// naturally occurs.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        /// <param name="data">The array to read bytes into. The array
        /// will be completely filled from the stream, so an appropriate
        /// size must be given.</param>
        private static void ReadWholeArray(Stream stream, ref byte[] data)
        {
            int offset = 0;
            int remaining = data.Length;
            while (remaining > 0)
            {
                int read = stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
        }
        private static void _read_data(ref byte[] buffer, string path)
        {
            System.IO.FileStream saveFile;
            saveFile = new FileStream(path, FileMode.Open);
            if (saveFile.Length < 1)
            {
                MessageBox.Show("Invalid file length", "Error");
                return;
            }
            buffer = new byte[saveFile.Length];
            //MessageBox.Show(buffer.Length.ToString());
            ReadWholeArray(saveFile, ref buffer);
            saveFile.Close();
            return;
        }
        public static int load_file(ref byte[] buffer, ref string path, string filter)
        {

            if (path == null)
            {
                OpenFileDialog openFD = new OpenFileDialog();
                //openFD.InitialDirectory = "c:\\";
                openFD.Filter = filter;
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    #region filename
                    path = openFD.FileName;
                    //MessageBox.Show(path.ToString());
                    #endregion
                    _read_data(ref buffer, path);
                    //MessageBox.Show(buffer.Length.ToString());
                    return buffer.Length;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                _read_data(ref buffer, path);
                return buffer.Length;
            }

        }
        private static byte[] dsvfoot = new byte[] {
                0x7C, 0x3C, 0x2D, 0x2D, 0x53, 0x6E, 0x69, 0x70, 0x20, 0x61, 0x62, 0x6F,
                0x76, 0x65, 0x20, 0x68, 0x65, 0x72, 0x65, 0x20, 0x74, 0x6F, 0x20, 0x63,
                0x72, 0x65, 0x61, 0x74, 0x65, 0x20, 0x61, 0x20, 0x72, 0x61, 0x77, 0x20,
                0x73, 0x61, 0x76, 0x20, 0x62, 0x79, 0x20, 0x65, 0x78, 0x63, 0x6C, 0x75,
                0x64, 0x69, 0x6E, 0x67, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x44, 0x65,
                0x53, 0x6D, 0x75, 0x4D, 0x45, 0x20, 0x73, 0x61, 0x76, 0x65, 0x64, 0x61,
                0x74, 0x61, 0x20, 0x66, 0x6F, 0x6F, 0x74, 0x65, 0x72, 0x3A, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x2D,
                0x44, 0x45, 0x53, 0x4D, 0x55, 0x4D, 0x45, 0x20, 0x53, 0x41, 0x56, 0x45,
                0x2D, 0x7C
            };


        public static void save_data(byte[] buffer)
        {   //if (savegamename.Text.Length < 1) return;
            if (buffer == null) return;
            SaveFileDialog saveFD = new SaveFileDialog();
            //saveFD.InitialDirectory = "c:\\";
            saveFD.Filter = "NDS RAW save data|*.sav|NDS Desmune/Drastic save data|*.dsv|All Files (*.*)|*.*";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream saveFile;
                saveFile = new FileStream(saveFD.FileName, FileMode.Create);

                //Write file
                var extension = Path.GetExtension(saveFD.FileName);
                switch (extension.ToLower())
                {
                    case ".sav":
                        //Write file
                        saveFile.Write(buffer, 0, buffer.Length);
                        break;
                    case ".dsv":
                        //Add dsv footer
                        byte[] dsv_save = new byte[SAV5.SIZERAW + 122];
                        buffer.CopyTo(dsv_save, 0);
                        dsvfoot.CopyTo(dsv_save, SAV5.SIZERAW);
                        //Write file
                        saveFile.Write(dsv_save, 0, dsv_save.Length);
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException(extension);
                        break;
                }

                saveFile.Close();
                MessageBox.Show("File Saved.", "Save file");
            }
        }
        public static void save_file(byte[] buffer, string filter)
        {   //if (savegamename.Text.Length < 1) return;
            if (buffer == null) return;
            SaveFileDialog saveFD = new SaveFileDialog();
            //saveFD.InitialDirectory = "c:\\";
            saveFD.Filter = filter;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream saveFile;
                saveFile = new FileStream(saveFD.FileName, FileMode.Create);
                //Write file
                saveFile.Write(buffer, 0, buffer.Length);
                saveFile.Close();
                MessageBox.Show("File Saved.", "Save file");
            }
        }
    }
}
