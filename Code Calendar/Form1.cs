using Calendar_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code_Calendar
{
    public partial class Form1 : Form
    {
        public static List<DayComponent> DayComponents = new List<DayComponent>();
        Month month; 
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (DayComponent dayComponent in DayComponents)
            {
                dayComponent.Select() 
            }
            DayComponent newTextBox = new DayComponent();
            DayComponent lastOldTextBox = DayComponents.LastOrDefault();
                if (lastOldTextBox == null)
                {
                    newTextBox.Location = new Point(30, 50);
                    newTextBox.Text = "Hello World!";
                }
                else
                {
                    newTextBox.Location = new Point(lastOldTextBox.Location.X, lastOldTextBox.Location.Y + 30);
                    newTextBox.Text = $"Hello World! ({DayComponents.Count})";
                }
                DayComponents.Add(newTextBox);
            this.Controls.Add(newTextBox);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
