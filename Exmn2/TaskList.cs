using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmn2
{
     public class TaskList
    {
        private String name { get; set; }
        private List<Task> tasks { get; set; }
        /// <summary>
        /// Конструктор инициализирует список задач с указанным именем.
        /// </summary>
        /// <param name="name"></param>
        public TaskList(String name)
        {
            this.name = name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            return name;
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// возвращает список задач на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            return tasks.Where(x => x.Due == DateTime.Now).ToList();
        }
        /// <summary>
        /// возвращает список задач на завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            return tasks.Where(x => x.Due > DateTime.Now).ToList();
        }

    }
}
