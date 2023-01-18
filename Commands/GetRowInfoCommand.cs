using HSchedule.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace HSchedule.Commands
{
    internal class GetRowInfoCommand : CommandBase
    {
        public ObservableCollection<TaskViewModel> Tasks { get; set; }

        public override void Execute(object parameter)
        {
            MessageBox.Show($"Имя: {TaskViewModel.Name}");
        }
    }
}
