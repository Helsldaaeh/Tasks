using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Class_Library
{
    //Важность задач по порядку(0 - синий (blue), 1 - зелёный (green), 2 - оранжевый (orange), 3 - красный (red)
    public enum ImportanceType
    {
        blue,   // 0
        green,  // 1
        orange, // 2
        red     // 3
    }
    // Класс задач
    public class Task
    {
        #region private
        private DateTime _time; // Время 
        private string _name; // Имя
        private string _description; // Описание
        private ImportanceType _importance; // Важность
        #endregion
        #region get/set
        public DateTime Time { get { return this._time; } set { this._time = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        public string Description { get { return this._description; } set { this._description = value; } }
        public ImportanceType Importance { get { return this._importance; }  set { this._importance = value; } }
        #endregion
        #region constructors
        //Конструктор с параметрами // Constructor with parameters
        public Task(DateTime timeP, string nameP, string descriptionP, ImportanceType importanceP)
        {
            _time = timeP;
            _name = nameP;
            _description = descriptionP;
            this._importance = importanceP;
        }
        //Конструктор по умолчанию // Defoult constructor
        public Task()
        {
            _time = new DateTime();
            _name = "Task";
            _description = "NONE";
            this._importance = ImportanceType.blue;
        }
        //Конструктор копирования // Copy constructor
        public Task(Task task)
        {
            _time = task._time;
            _name = task._name;
            _description = task._description;
            this._importance = task._importance;
        }
        #endregion
    }
}