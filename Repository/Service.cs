using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Data;

namespace Repository
{
    public class Service
    {
        private TaskRepos _taskRepos;

        public Service(TaskRepos taskRepos)
        {
            _taskRepos = taskRepos;
        }

        public List<TaskListt> GetTaskListts()
        {
            return _taskRepos.taskListts.ToList();
        }

        public int CreateTaskList(TaskListt taskListt)
        {
            taskListt.TaskListId = 10;
            _taskRepos.taskListts.Add(taskListt);
            return taskListt.TaskListId;
        }

        public List<Taskkk> GetByListId(int taskListId)
        {
            return _taskRepos.taskkks.Where(x => x.TaskListId == taskListId).ToList();
        }

        public List<Taskkk> CreateTask(Taskkk taskkk)
        {
            taskkk.TaskId = 11;
            _taskRepos.taskkks.Add(taskkk);
            return GetByListId(taskkk.TaskListId);
        }

        public void DeleteTaskList(int taskListId) 
        {
            var taskList = _taskRepos.taskListts.Where(x => x.TaskListId == taskListId).FirstOrDefault();
            _taskRepos.taskListts.Remove(taskList);
        }

        public void DeleteTask(int taskId)
        {
            var task = _taskRepos.taskkks.Where(x => x.TaskId == taskId).FirstOrDefault();
            _taskRepos.taskkks.Remove(task);
        }
    }
}
