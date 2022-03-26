using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using WorkFlow.Models.Messages;

namespace WorkFlow.Comsumers
{
    public class WorkflowConsumer : IConsumeAsync<Message<WorkflowModel>>
    {
        //[AutoSubscriberConsumer(SubscriptionId = "Workflow")]
        public async Task ConsumeAsync(Message<WorkflowModel> message, CancellationToken cancellationToken = default)
        {

        }
    }
}
