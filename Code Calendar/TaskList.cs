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
using System.Xml;

namespace Code_Calendar 
{
    public partial class TaskList : Form
    {
        private CalendarViewModel vm;
        public TaskList(Calendar_Class_Library.TaskList tasks)
        {
            InitializeComponent();
            if (tasks.Tasks.Count > 0)
            {
                for (int i = 0; i < tasks.GetSize(); i++) 
                {
                    comboBox1.Items.Add(tasks.Tasks[i].Name);
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main.stackofdays.Last().tasks.AddTask(new Calendar_Class_Library.Task(new DateTime(0,0,0,0,0,0), textBox1.Text, textBox3.Text, ImportanceType.blue));
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
        }
    }
}
