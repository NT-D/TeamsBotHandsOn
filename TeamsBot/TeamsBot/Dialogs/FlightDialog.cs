using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace TeamsBot.Dialogs
{
    [Serializable]
    public class FlightDialog : IDialog<object>
    {
        string destination;
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Welcome to FlightDialog");
            await context.PostAsync("Where do you want to go?");
            context.Wait(AskOrigin);
        }

        private async Task AskOrigin(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var reply = await result;
            destination = reply.Text;
            await context.PostAsync($"OK you want to go {destination}.Where is the origin place?");
            context.Wait(BookFlight);
        }

        private async Task BookFlight(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var reply = await result;
            await context.PostAsync($"OK, booked the flight from {reply.Text} to {destination}. Have a nice trip :)");
            context.Done<object>(destination);
        }
    }
}