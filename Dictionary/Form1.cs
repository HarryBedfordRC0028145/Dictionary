using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> prefixes = new Dictionary<string, double>()
            {
                {"nm", 1e-9 },
                {"um", 1e-6 },
                {"mm", 1e-3 },
                {"cm", 1e-2 },
                {"m", 1 },
                {"km", 1e-3 },
                {"Mm", 1e-6 },
                {"Gm", 1e-9 }
            };
            {
                {"nm", 1e-18 },
                {"um", 1e-12 },
                {"mm", 1e-6 },
                {"cm", 1e-4 },
                {"m", 2 },
                {"km", 1e-6},
                {"Mm", 1e-12},
                {"Gm", 1e-18}
            };


            public Form1()
            {
                InitializeComponent();
                foreach (string k in prefixes.Keys)
                {
                    comboBox6.Items.Add(k);
                    comboBox5.Items.Add(k);
                }
                comboBox6.SelectedIndex = 4;
                comboBox5.SelectedIndex = 4;
                Update();
            }

            void update()
            {
                try
                {
                    double d = double.Parse(textBox3.Text);
                    double d2 = d * prefixes[comboBox6.Text] / prefixes[comboBox5.Text];
                    label2.Text = d2.ToString();
                }
                catch
                {
                    label2.Text = "";
                }

            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
