using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using WorkFlow.Models.Messages;

namespace WorkFlow.Comsumers
{
    public class WorkflowConsumer : IConsumeAsync<Message<WorkflowModel>>
    {
        public async Task ConsumeAsync(Message<WorkflowModel> message, CancellationToken cancellationToken = default)
        {
        }
    }
}
