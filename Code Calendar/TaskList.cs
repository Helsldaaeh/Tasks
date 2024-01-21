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
using Day = Calendar_Class_Library.Day;

namespace Code_Calendar 
{
    public partial class TaskList : Form
    {
        private CalendarViewModel vm;
        private Day currentDay;
        public TaskList(Calendar_Class_Library.TaskList tasks, Calendar_Class_Library.Day day)
        {
            InitializeComponent();
            this.currentDay = day;
            if (tasks.Tasks.Count > 0)
            {
                comboBox1.Items.AddRange(tasks.Tasks.ToArray());
                comboBox1.SelectedIndex = 0;
                textBox2.Text = tasks.Tasks[comboBox1.SelectedIndex].Description;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var task = new Calendar_Class_Library.Task(DateTime.Today, textBox1.Text, textBox3.Text, ImportanceType.blue);
            currentDay.Tasks.AddTask(task);
            comboBox1.Items.Add(task);
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            textBox2.Text = (comboBox.SelectedItem as Calendar_Class_Library.Task).Description;

        }
    }
}
