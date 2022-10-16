using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du___Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vstup = textBox1.Lines;
            int maxIndex = -1;
            TimeSpan rozdil;
            try
            {
                int max = 0, pocitadlo = 0;
                foreach (string line in vstup)
                {
                    string datum = line.Substring(line.IndexOf(';', line.IndexOf(';') + 1) + 1);
                    datum = datum.Replace(" ", "");
                    rozdil = DateTime.Now - DateTime.Parse(datum);
                    if(max < rozdil.Days)
                    {
                        max = rozdil.Days;
                        maxIndex = pocitadlo;
                    }
                    pocitadlo++;
                }
                label1.Text = "Nejstarší člověk: " + vstup[maxIndex].Replace(" ","").Replace(";"," ");
            } catch { 
                MessageBox.Show("Nesprávné tvar zápisu!! Prosím opravte!","Chyba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
