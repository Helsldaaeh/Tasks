using Calendar_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Calendar
{
    public partial class DayComponent : UserControl
    {
        public Calendar_Class_Library.TaskList tasks;
        public int numberofday;
        public DayComponent(Calendar_Class_Library.TaskList tasks, int daytitle)
        {
            InitializeComponent();
            this.tasks = tasks;
            this.button1.Text = daytitle.ToString();
            numberofday = daytitle;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            TaskList form = new TaskList(tasks);
            form.ShowDialog();
            Main.stackofdays.Add(this);
        }

    }
}
