using System.Collections.Generic;

namespace Exercise_5
{
    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetTasks())
                activity.Execute();
        }

    }

}
