using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;


namespace TeamsBot.Dialogs
{
    [Serializable]
    public class LuisCallDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("何が知りたいですか？");
            context.Wait(MessageReceiveAsync);
        }

        private async Task MessageReceiveAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            //TODO: Add LUIS communication
            await context.PostAsync("testing messege receive");
            context.Done<object>(null);
        }
    }
}