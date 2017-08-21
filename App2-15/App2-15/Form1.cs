using System;
using System.Linq;
using System.Windows.Forms;

namespace App2_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ResultMatrix.Text = null;

           var n = TArray.Lines.Length;
            var m = TArray.Lines[0].Split(',').Length;

            var a = new double[n,m];
          
            for (var i = 0; i < n; i++)
            {
                var row = TArray.Lines[i].Split(',').Select(val => double.Parse(val.Trim())).ToArray();
                for (var j = 0; j < m; j++)
                {
                    a[i, j] = row[j];
                }
            }

            MatrixLineSorter.Sort(a);

            for (var i = 0; i < n; i++)
            {                
                for (var j = 0; j < m; j++)
                {
                    ResultMatrix.Text = ResultMatrix.Text + a[i, j].ToString("0 ");
                }

                ResultMatrix.Text = ResultMatrix.Text +  Environment.NewLine;
            }
        }
    }
}
