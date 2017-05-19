using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace TeamsBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        private const string FlightMenu = "Book Flight";
        private const string HotelMenu = "Book Hotel";
        private const string QAMenu = "Q&A";

        private List<string> mainMenuList = new List<string>() { FlightMenu, HotelMenu, QAMenu };
        private string location;

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Welcome to Root Dialog");
            context.Wait(MessageReceiveAsync);
        }

        private async Task MessageReceiveAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var reply = await result;
            if (reply.Text.ToLower().Contains("help"))
            {
                await context.PostAsync("You can implement help menu here");
            }
            else
            {
                await ShowMainmenu(context);
            }
        }

        private async Task ShowMainmenu(IDialogContext context)
        {
            //Show menues
            PromptDialog.Choice(context, this.CallDialog, this.mainMenuList, "What do you want to do?");
        }

        private async Task CallDialog(IDialogContext context, IAwaitable<string> result)
        {
            //This method is resume after user choise menu
            var selectedMenu = await result;
            switch (selectedMenu)
            {
                case FlightMenu:
                    //Call child dialog without data
                    context.Call(new FlightDialog(), ResumeAfterDialog);
                    break;
                case HotelMenu:
                    //Call child dialog with data
                    context.Call(new HotelDialog(location), ResumeAfterDialog);
                    break;
                case QAMenu:
                    context.Call(new LuisCallDialog(),ResumeAfterDialog);
                    break;
            }
        }

        private async Task ResumeAfterDialog(IDialogContext context, IAwaitable<object> result)
        {
            //Resume this method after child Dialog is done.
            var test = await result;
            if (test != null)
            {
                location = test.ToString();
            }
            else
            {
                location = null;
            }
            await this.ShowMainmenu(context); 
        }
    }
}