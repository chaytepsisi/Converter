using System.Windows.Forms;

namespace Converter
{
    public partial class OutputWindow : Form
    {
        public OutputWindow()
        {
            InitializeComponent();
        }

        public OutputWindow(string input)
        {
            InitializeComponent();
            richTextBox1.Text = input;
        }
    }
}