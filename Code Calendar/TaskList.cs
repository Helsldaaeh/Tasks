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

namespace Code_Calendar
{
    public partial class TaskList : Form
    {
        public TaskList(Calendar_Class_Library.TaskList tasks)
        {
            InitializeComponent();

            if (tasks.Tasks.Count > 0)
            {
                for (int i = 0; i < tasks.GetSize(); i++) { comboBox1.Items.Add(tasks); }
                comboBox1.SelectedIndex = 0;
                textBox2.Text = tasks.Tasks[comboBox1.SelectedIndex].Description;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
