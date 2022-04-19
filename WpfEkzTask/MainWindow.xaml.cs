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

namespace WpfEkzTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskRepos _taskRepos;

        private Service _service;
        public MainWindow()
        {
            InitializeComponent();

            _taskRepos = new TaskRepos();
            _service = new Service(_taskRepos);
        }

        public void Update()
        {
            listViewTasklist.ItemsSource = _service.GetTaskListts();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void addBtn(object sender, RoutedEventArgs e)
        {
            var taskListName = textTaskList.Text;
            var taskList = new TaskListt()
            {
                TaskListId = 11,
                Name = taskListName
            };
            _service.CreateTaskList(taskList);
            Update();
        }

        private void delBtn(object sender, RoutedEventArgs e)
        {
            var selected = (TaskListt)listViewTasklist.SelectedItem;
            if (selected != null) _service.DeleteTaskList(selected.TaskListId);
            Update();
        }

        private void listViewTasklist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = (TaskListt)listViewTasklist.SelectedItem;
            var taskList = new TaskListt() { TaskListId = selected.TaskListId, Name = selected.Name };
            var page = new Pages.TaskPage(taskList.TaskListId, _taskRepos);
            taskFrame.Navigate(page);
        }
    }
}
