using System.IO;
using System.Windows.Forms;

namespace WangPluginSav.Util.WC3;

public class FileIO
{
    private static void ReadWholeArray(Stream stream, ref byte[] data)
    {
        int num = 0;
        int num2 = data.Length;
        while (num2 > 0)
        {
            int num3 = stream.Read(data, num, num2);
            if (num3 <= 0)
            {
                throw new EndOfStreamException($"End of stream reached with {num2} bytes left to read");
            }
            num2 -= num3;
            num += num3;
        }
    }

    private static void _read_data(ref byte[] buffer, string path)
    {
        FileStream fileStream = new FileStream(path, FileMode.Open);
        if (fileStream.Length < 1)
        {
            MessageBox.Show("Invalid file length", "Error");
            return;
        }
        buffer = new byte[fileStream.Length];
        ReadWholeArray(fileStream, ref buffer);
        fileStream.Close();
    }

    public static int load_file(ref byte[] buffer, ref string path, string filter)
    {
        if (path == null)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                _read_data(ref buffer, path);
                return buffer.Length;
            }
            return -1;
        }
        _read_data(ref buffer, path);
        return buffer.Length;
    }

    public static void save_data(byte[] buffer, string filter)
    {
        if (buffer != null)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                fileStream.Write(buffer, 0, buffer.Length);
                fileStream.Close();
                MessageBox.Show("File Saved.", "Save file");
            }
        }
    }
}
