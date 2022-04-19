using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Repository;
using Repository.Data;

namespace WpfEkzTask.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        private TaskRepos _taskRepos;

        private Service _service;

        private int _taskListId;
        public TaskPage(int taskListId, TaskRepos taskRepository)
        {
            InitializeComponent();

            _taskRepos = taskRepository;
            _taskListId = taskListId;
            _service = new Service(taskRepository);
        }

        public void Update()
        {
            listViewTask.ItemsSource = _service.GetByListId(_taskListId);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void addBtn(object sender, RoutedEventArgs e)
        {
            var customListName = textTask.Text;
            var task = new Taskkk()
            {
                Done = false,
                Title = customListName,
                TaskListId = _taskListId,
                Due = DateTime.Now
            };
            _service.CreateTask(task);
            Update();
        }

        private void delBtn(object sender, RoutedEventArgs e)
        {
            var selected = (Taskkk)listViewTask.SelectedItem;
            if (selected != null) _service.DeleteTask(selected.TaskId);
            Update();
        }
    }
}
