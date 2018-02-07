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

        Dictionary<string, double> areas = new Dictionary<string, double>()
        {
                {"nm²", 1e-18 },
                {"um²", 1e-12 },
                {"mm²", 1e-6 },
                {"cm²", 1e-4 },
                {"m²", 1 },
                {"km²", 1e-6},
                {"Mm²", 1e-12},
                {"Gm²", 1e-18}
         };
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (string k in areas.Keys)
            {
                comboBox7.Items.Add(k);
                comboBox9.Items.Add(k);
            }
            comboBox7.SelectedIndex = 4;
            comboBox9.SelectedIndex = 4;
            Update();
        }

        void update2()
        {
            try
            {
                double d = double.Parse(textBox4.Text);
                double d2 = d * areas[comboBox7.Text] / areas[comboBox9.Text];
                label3.Text = d2.ToString();
            }
            catch
            {
                label3.Text = "";
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            update2();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            update2();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            update2();
        }

        Dictionary<string, double> volume = new Dictionary<string, double>()
        {
                {"nm³", 1e-27 },
                {"um³", 1e-18 },
                {"mm³", 1e-9 },
                {"cm³", 1e-6 },
                {"m³", 1 },
                {"km³", 1e-9},
                {"Mm³", 1e-18},
                {"Gm³", 1e-27}
         };
    }
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            foreach (string k in volume.Keys)
            {
                comboBox6.Items.Add(k);
                comboBox5.Items.Add(k);
            }
            comboBox6.SelectedIndex = 4;
            comboBox5.SelectedIndex = 4;
            Update();
        }

        void update3()
        {
            try
            {
                double d = double.Parse(textBox5.Text);
                double d2 = d * volume[comboBox8.Text] / volume[comboBox10.Text];
                label4.Text = d2.ToString();
            }
            catch
            {
                label4.Text = "";
            }

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            update3();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            update3();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            update3();
        }
    }
}
