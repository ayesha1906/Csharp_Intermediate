using System.Collections.Generic;

namespace Exercise_5
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

}
