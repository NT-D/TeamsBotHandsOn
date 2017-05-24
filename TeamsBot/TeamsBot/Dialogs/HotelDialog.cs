using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace TeamsBot.Dialogs
{
    [Serializable]
    public class HotelDialog : IDialog<object>
    {
        string hotelLocation;
        public HotelDialog(string location)
        {
            hotelLocation = location;
        }

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Welcome to HotelDialog");
            if (hotelLocation == null)
            {
                await context.PostAsync("Where do you want to go?");
                context.Wait(AskDuration);
            }
            else
            {
                await context.PostAsync("How long do you want to stay?");
                context.Wait(BookHotel);
            }
        }

        private async Task AskDuration(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var reply = await result;
            hotelLocation = reply.Text;
            await context.PostAsync($"OK, you want to go {hotelLocation}.How long do you want to stay?");
            context.Wait(BookHotel);
        }

        private async Task BookHotel(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var reply = await result;
            await context.PostAsync($"Booked room for people in the {hotelLocation} for {reply.Text} days.");
            context.Done<object>(hotelLocation);
        }
    }
}