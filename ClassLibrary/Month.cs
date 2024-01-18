using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Class_Library
{
    public class Month
    {
        #region private
        private List<Day> _daylist;
        private int number_of_month;
        #endregion
        #region set/get
        public List<Day> Daylist { get => _daylist; set => _daylist = value; }
        public int Number_of_month { get => number_of_month; set => number_of_month = value; }
        #endregion
        Month(List<Day> dayarr,int number_of_monthP) { Daylist = dayarr; Number_of_month = number_of_monthP; }
        public void ClearTask()
        {
            for (int i  = 0; i < _daylist.Count; i++)
            {
                Day _day = _daylist[i];
            }
        }
    }
}
