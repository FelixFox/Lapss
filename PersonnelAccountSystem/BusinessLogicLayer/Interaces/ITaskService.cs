using PersonnelAccountSystem.BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountSystem.BusinessLogicLayer.Interaces
{
    public interface ITaskService
    {
        IEnumerable<TaskDTO> GetTaskListForEmployee(int id);
        bool RemoveTask(int id_task);
        bool AddTask(TaskDTO task);
        bool ChangeTaskInfo(TaskDTO oldTask,TaskDTO newTask);
        IEnumerable<TaskDTO> getDoneTasks(int id_employee);
        IEnumerable<TaskDTO> getUndoneTasks(int id_employee);

        void Dispose();
    }
}
