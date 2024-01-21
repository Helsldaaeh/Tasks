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
    public partial class Main : Form
    {
        public static List<DayComponent> DayComponents = new List<DayComponent>();
        private CalendarViewModel vm;

        private void ShowMonth(Month month)
        {
            int startX = 12;
            int startY = 89;
            int sizeX = 100;
            int sizeY = 47;
            int countWeeks = 0;
            for (int i = 0; i < month.NumberOfDays; i++)
            {
                DayComponent nextDayComponent = new DayComponent(month.Daylist[i].Tasks, i + 1);
                DayComponent lastPlacedDayComponent = DayComponents.LastOrDefault();
                nextDayComponent.Location = new Point(startX + (sizeX * ((month.Start + i) % 7) + 10), startY + (sizeY * countWeeks) + 5);
                if (((month.Start + i) % 7) == 6) countWeeks++;
                DayComponents.Add(nextDayComponent);
                this.Controls.Add(nextDayComponent);
            }
        }

        Month month;
        public Main()
        {
            InitializeComponent();
            vm = new CalendarViewModel();
            vm.AddSomeTasks(new List<Calendar_Class_Library.Task>()
            {
                new Calendar_Class_Library.Task(),
                new Calendar_Class_Library.Task(),
                new Calendar_Class_Library.Task(),
                new Calendar_Class_Library.Task(),
            });
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMonth(vm.GetCurrentMonth());

        }
    }
}
