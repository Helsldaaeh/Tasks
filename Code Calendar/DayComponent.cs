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
        private TaskList tasks;

        public DayComponent(TaskList tasks)
        {
            InitializeComponent();
            this.tasks = tasks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(tasks);
            form.ShowDialog();
        }
    }
}
