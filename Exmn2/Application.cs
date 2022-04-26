using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmn2
{
    public class Application
    {
        private Application application { get; set; }
        private List<TaskList> taskLists { get; set; }

        private Application()
        {
            TaskList tasklist = new TaskList("Входящие");
            taskLists.Add(tasklist);
        }
        /// <summary>
        /// возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application != null) return application;
            else return application = new Application();
        }
        /// <summary>
        /// создает список с задачами и добавляет его в список со списками задач
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(String name)
        {
            TaskList tasklist = new TaskList(name);
            taskLists.Add(tasklist);
        }
        /// <summary>
        /// возвращает последний список задач по указанному имени.
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            List<string> stringlist = new List<string>();
            foreach (TaskList name in taskLists)
            {
                stringlist.Add(name.GetName());
            }
            return stringlist;
        }
        /// <summary>
        /// просматривает список со списком задач, получает у каждого списка задач список задач на сегодня 
        /// и возвращает общий список в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTaskByToday()
        {
            List<Task> tasklist = new List<Task>();
            foreach (var task in taskLists)
            {
                tasklist.AddRange(task.GetTasksByToday());
            }
            return tasklist;
        }
        /// <summary>
        /// просматривает список со списком задач, получает у каждого списка задач список задач на завтра и позже 
        /// и возвращает общий список в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTaskByFuture()
        {
            List<Task> tasklist = new List<Task>();
            foreach (var task in taskLists)
            {
                tasklist.AddRange(task.GetTasksByFuture());
            }
            return tasklist;
        }
    }
}
