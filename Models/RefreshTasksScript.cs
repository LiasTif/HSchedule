using HSchedule.Models.DataBase;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Models
{
    public class RefreshTasksScript
    {
        public void Refresh()
        {
            MainMenuViewModel.Tasks = TasksDeserialization.GetTasks();
        }
    }
}
