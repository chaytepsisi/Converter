using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operationCBox.DataSource = Basics.fileOperations;
            outputCBox.DataSource = Basics.outputOperations;
        }

        private void bin2hexButton_Click(object sender, EventArgs e)
        {
            try
            {
                hexOutRtb.Text = Converters.BinaryStringToHexString(binaryInRtb.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void hex2binButton_Click(object sender, EventArgs e)
        {
            try
            {
                binaryOutRtb.Text = Converters.HexStringToBinaryString(hexInRtb.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            string firstString = String.Empty;
            string secondString = String.Empty;

            string tempString = input1.Text;

            tempString = tempString.Replace("0x", String.Empty);
            tempString = tempString.Replace(",", String.Empty);
            tempString = tempString.Replace(" ", String.Empty);

            if (Regex.IsMatch(tempString, "[^A-Fa-f0-9]"))//Herhangi bir text
            {
                firstString = tempString;
            }
            else if (Regex.IsMatch(tempString, "[^01]"))////Hexadecimal text
            {
                firstString = Converters.HexStringToBinaryString(tempString);
            }
            else //Binary text
            {
                firstString = tempString;
            }

            tempString = input2.Text;

            tempString = tempString.Replace("0x", String.Empty);
            tempString = tempString.Replace(",", String.Empty);
            tempString = tempString.Replace(" ", String.Empty);

            if (Regex.IsMatch(tempString, "[^A-Fa-f0-9]"))//Herhangi bir text
            {
                secondString = tempString;
            }
            else if (Regex.IsMatch(tempString, "[^01]"))////Hexadecimal text
            {
                secondString = Converters.HexStringToBinaryString(tempString);
            }
            else //Binary text
            {
                secondString = tempString;
            }

            string resultString = String.Empty;
            if (firstString.CompareTo(secondString) == 0)
                resultString = " are equal";
            else
            {
                string trimmedFirstString = firstString.TrimStart('0').TrimEnd(' ');
                string trimmedSecondString = secondString.TrimStart('0').TrimEnd(' ');
                if (trimmedFirstString.CompareTo(trimmedSecondString) == 0)
                {
                    resultString = " are equal EXCEPT the leading zeros and spaces..";
                }
                else resultString = " are NOT equal!";
            }

            MessageBox.Show("The inputs" + resultString);
        }

        private void convertToArray_CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string arrayStyleString = Converters.HexStringToArrayStyle(hexOutRtb.Text);
                Clipboard.SetText(arrayStyleString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static string fileInput = String.Empty;
        private static string filePath = String.Empty;

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileInput = File.OpenFile(ref filePath);
                inputPathRtx.Text = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void convertFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string output = String.Empty;
                if (operationCBox.Text == Basics.BIN_TO_HEX)
                {
                    output = Converters.BinaryStringToHexString(fileInput);
                }
                else if (operationCBox.Text == Basics.HEX_TO_BIN)
                {
                    output = Converters.HexStringToBinaryString(fileInput);
                }
                else if (operationCBox.Text == Basics.BIN_TO_HEX_ARR)
                {
                    output = Converters.BinaryStringToHexString(fileInput);
                    output = Converters.HexStringToArrayStyle(output);
                }
                else if (operationCBox.Text == Basics.HEX_TO_HEX_ARR)
                {
                    output = Converters.HexStringToArrayStyle(fileInput);
                }

                if (outputCBox.Text == Basics.OUTPUT_WINDOW)
                {
                    OutputWindow outputWindow = new OutputWindow(output);
                    outputWindow.Show();
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File|*.txt";
                    saveFileDialog.OverwritePrompt = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName);
                        outputFile.Write(output);
                        outputFile.Flush();
                        outputFile.Close();
                        outputPathRtx.Text = saveFileDialog.FileName;
                        MessageBox.Show(filePath + " file is converted and saved to " + saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void alignButton_Click(object sender, EventArgs e)
        {
            string text = binaryOutRtb.Text;
            binaryOutRtb.Clear();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                stringBuilder.Append(text[i]);
                if ((i + 1) % 4 == 0)
                    stringBuilder.Append(" ");
            }
            binaryOutRtb.Text = stringBuilder.ToString();
        }
    }
}