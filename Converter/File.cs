using System;
using System.IO;
using System.Windows.Forms;

namespace Converter
{
    internal class File
    {
        public static string OpenFile(ref string path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TextFile |*.txt";
            string inputString = String.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                path = filePath;
                try
                {
                    StreamReader streamReader = new StreamReader(filePath);
                    inputString = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return inputString;
        }
    }
}