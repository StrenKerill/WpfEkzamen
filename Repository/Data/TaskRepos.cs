using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class TaskRepos
    {
        public List<Taskkk> taskkks;

        public List<TaskListt> taskListts;

        public TaskRepos()
        {
            taskListts = new List<TaskListt>
            {
                new TaskListt() { TaskListId = 1, Name = "Тест первый" },
                new TaskListt() { TaskListId = 2, Name = "Тест второй" }
            };

            taskkks = new List<Taskkk>
            {
                new Taskkk() { TaskId = 1, Done = false, TaskListId = 1, Title = "Первая задача", Due = DateTime.Now },
                new Taskkk() { TaskId = 2, Done = false, TaskListId = 1, Title = "Вторая задача", Due = DateTime.Now },
                new Taskkk() { TaskId = 3, Done = false, TaskListId = 1, Title = "Третья задача", Due = DateTime.Now },
                new Taskkk() { TaskId = 4, Done = false, TaskListId = 2, Title = "Четвертая задача", Due = DateTime.Now },
                new Taskkk() { TaskId = 5, Done = false, TaskListId = 2, Title = "Пятая задача", Due = DateTime.Now },
                new Taskkk() { TaskId = 6, Done = false, TaskListId = 2, Title = "Шестая задача", Due = DateTime.Now }
            };
        }
    }
}
