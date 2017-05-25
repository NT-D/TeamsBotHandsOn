using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Cognitive.LUIS;
using TeamsBot.Services;

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
            var userInput = await result;
            LuisService luisService = new LuisService();
            string intent = await luisService.GetTopIntent(userInput.Text);

            switch (intent)
            {
                case "AskNewinfo":
                    await context.PostAsync($"最新情報が知りたいのですね。[このリンク](https://blogs.technet.microsoft.com/office365-tech-japan/)を確認してみてください。");
                    break;
                case "AskHowto":
                    await context.PostAsync($"How toが知りたいのですね。[このリンク](https://blogs.msdn.microsoft.com/lync_support_team_blog_japan/)を確認してみてください。");
                    break;
            }
            context.Done<object>(null);
        }
    }
}