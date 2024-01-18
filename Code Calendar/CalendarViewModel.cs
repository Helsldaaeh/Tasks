using Calendar_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Calendar
{
    public class CalendarViewModel
    {
        private List<Month> monthList;
        private int currentMonth;
        

        public List<Month> MonthList { get => monthList; set => monthList = value; }
        public CalendarViewModel()
        {
            monthList = InitMonthList();
            currentMonth = 0;
        }
        private List<Month> InitMonthList()
        {
            List<Month> _listOMonth = new List<Month>();

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    _listOMonth.Add(new Month(CreateMonth(31),i,i == 0? 0 : (_listOMonth[i - 1].Start + _listOMonth[i-1].NumberOfDays) % 7));
                }
                else
                {
                    _listOMonth.Add(new Month(CreateMonth(i == 1 ? 29 : 30),i,(_listOMonth[i - 1].Start + _listOMonth[i - 1].NumberOfDays) % 7));
                }
            }

            return _listOMonth;
        }

        private List<Day> CreateMonth(int numberOfDays)
        {
            List<Day> _listODay = new List<Day>();

            for (int i = 0; i < numberOfDays; i++)
            {
                _listODay.Add(new Day(new Calendar_Class_Library.TaskList(), i));
            }
            return _listODay;
        }
        public void AddSomeTasks(List<Calendar_Class_Library.Task> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                for (int j = 0; j < monthList[i].NumberOfDays; j++)
                {
                    if (j % 5 == 0) { monthList[i].Daylist[j].Tasks.AddTask(tasks[i]); }
                }
            }
        }
        public void IncreaseCurrentMonth()
        {
            currentMonth = currentMonth + 1 > 11?0:currentMonth + 1;
        }
        public Month GetCurrentMonth()
        {
            return monthList[currentMonth];
        }
        public void DecreaseCurrentMonth()
        {
            currentMonth = currentMonth - 1 < 0 ? 11 : currentMonth - 1;
        }


    }
}
