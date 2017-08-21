using System;
using System.Linq;
using System.Windows.Forms;

namespace App1_15
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            var etalon = double.Parse(InputEtalonLength.Lines[0].Trim());

            var text = textArray.Lines[0];
            var lengths = text.Split(',').Select(val => double.Parse(val.Trim())).ToArray();

            var result = LengthsProcessor.Process(etalon, lengths);

            if (result.Count > 0)
            {
                MaxDiff.Text = result.Max.ToString();
                DiffCount.Text = result.Count.ToString();
            }
            else
            {
                MaxDiff.Text = "-";
                DiffCount.Text = "0";
            }
        }
    }
}
