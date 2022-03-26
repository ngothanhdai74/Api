
using EasyNetQ;

namespace WorkFlow.Models.Messages
{
    [Queue(nameof(WorkflowModel))]
    public class WorkflowModel
    {
        public string Name { get; set; }
    }
}
