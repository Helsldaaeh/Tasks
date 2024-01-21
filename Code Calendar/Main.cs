using Calendar_Class_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Code_Calendar
{
    public partial class Main : Form
    {
        string[] MonthNames = { "Январь", "Февраль", "Март",
                                "Апрель", "Май", "Июнь",
                                "Июль", "Август", "Сентябрь",
                                "Октябрь", "Ноябрь", "Декабрь" };
        public static int indexofmonth = 0;
        public static List<DayComponent> DayComponents = new List<DayComponent>();
        private CalendarViewModel vm;
        public static List<DayComponent> stackofdays; 

        private void ShowMonth(Month month)
        {
            int startX = 14;
            int startY = 119;
            int sizeX = 180;
            int sizeY = 100;
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
            ShowMonth(vm.MonthList[indexofmonth]);
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            indexofmonth = 0;
            label10.Text = DateTime.Now.ToString();
            label8.Text = MonthNames[indexofmonth];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (indexofmonth + 1 > 11)
            {
                indexofmonth = 0;
                for (int i = 0; i < DayComponents.Count; i++)
                {
                    DayComponents[i].Enabled = false;
                    DayComponents[i].Hide();
                }
                label8.Text = MonthNames[indexofmonth];
                ShowMonth(vm.MonthList[indexofmonth]);
            }

            else
            {
                indexofmonth++;
                for (int i = 0; i < DayComponents.Count; i++)
                {
                    DayComponents[i].Enabled = false;
                    DayComponents[i].Hide();
                }
                label8.Text = MonthNames[indexofmonth];
                ShowMonth(vm.MonthList[indexofmonth]);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (indexofmonth - 1 < 0)
            {
                indexofmonth = 11;
                for (int i = 0; i < DayComponents.Count; i++)
                {
                    DayComponents[i].Enabled = false;
                    DayComponents[i].Hide();
                }
                label8.Text = MonthNames[indexofmonth];
                ShowMonth(vm.MonthList[indexofmonth]);
            }
            else
            {
                indexofmonth--;
                for (int i = 0; i < DayComponents.Count; i++)
                {
                    DayComponents[i].Enabled = false;
                    DayComponents[i].Hide();
                }
                label8.Text = MonthNames[indexofmonth];
                ShowMonth(vm.MonthList[indexofmonth]);
            }
        }
    }
}
