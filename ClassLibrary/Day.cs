using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Class_Library
{
    public enum WeekNames
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    public class Day
    {
        #region private
        private TaskList _tasks;
        private int _number_of_day;
        #endregion
        #region get/set
        public TaskList Tasks { get { return this._tasks; } set { this._tasks = value; } }
        public int NumberOfDays { get { return this._number_of_day; } set { this._number_of_day = value; } }
        #endregion
        #region constructors
        //Конструктор с параметрами // Constructor with parameters
        public Day(TaskList tasksP, int number_of_dayP)
        {
            _tasks = tasksP;
            _number_of_day = number_of_dayP;
        }
        // Конструктор копирования // Copy constructor
        public Day(Day DayP)
        {
            _tasks = DayP._tasks;
            _number_of_day = DayP._number_of_day;
        }
        // Констркутор по умолчанию // Default constructor
        public Day()
        {
            _tasks = new TaskList();
            _number_of_day = new int();
        }
        #endregion
        // Очистить задачи
        public void ClearTask()
        {
            this._tasks.ClearTask();
        }
    }
}