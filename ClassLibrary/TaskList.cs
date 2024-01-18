using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Class_Library
{
    public class TaskList
    {
        private List<Task> _tasks;

        public TaskList()
        {
            _tasks = new List<Task>();
        }
        public TaskList(List<Task> TasksP)
        {
            _tasks = TasksP;
        }

        public List<Task> Tasks { get => _tasks; set => _tasks = value; }
        // Добавление объекта по индексу
        public void AddTask(Task task, int index = 0)
        {
            this.Tasks.Insert(index, task);
        }
        // Удаление объекта по индексу
        public void DeleteTaskIndex(int index)
        {
            this.Tasks.RemoveAt(index);
        }
        // Удаление искомого объекта
        public void DeleteTaskElement(Task Element)
        {
            this.Tasks.Remove(Element);
        }
        // Проверка на пустоту
        public bool isEmpty(int index = 0) { return this.Tasks.Count == 0; }
        // Сортировка по важности от самых менее значимых до самых значимых 
        public void ImportanceSort()
        {
            for (int i = 0; i < this.Tasks.Count(); i++)
            {
                for (int j = 0; j < this.Tasks.Count(); j++)
                {
                    if (this.Tasks[i].Importance < this.Tasks[j].Importance)
                    {
                        Task bubble = this.Tasks[j];
                        this.Tasks[j] = this.Tasks[i];
                        this.Tasks[i] = bubble;
                    }
                }
            }
        }
        // Очистка заданий
        public void ClearTask()
        {
            this._tasks.Clear();
        }
        public int GetSize()
        {
            return this._tasks.Count;
        }
    }
}
