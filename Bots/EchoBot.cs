// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.15.2

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EchoBot1.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            Dictionary<string, string> responses = new Dictionary<string, string>();
            responses.Add("Hi", "Hello and welcome!");
            responses.Add("Name", "I am Vamsi.");
            responses.Add("Age", "My age is 40.");
            responses.Add("City", "I'm from Bangalore.");
            responses.Add("Country", "I am from India.");

            var requestQuestion = turnContext.Activity.Text;
            string responseText;
            if (requestQuestion.Contains("Name", System.StringComparison.InvariantCultureIgnoreCase))
                responseText = responses["Name"];
            else if (requestQuestion.Contains("Hi", System.StringComparison.InvariantCultureIgnoreCase))
                responseText = responses["Hi"];
            else if (requestQuestion.Contains("Age", System.StringComparison.InvariantCultureIgnoreCase))
                responseText = responses["Age"];
            else if (requestQuestion.Contains("City", System.StringComparison.InvariantCultureIgnoreCase))
                responseText = responses["City"];
            else if (requestQuestion.Contains("Country", System.StringComparison.InvariantCultureIgnoreCase))
                responseText = responses["Country"];
            else
                responseText = "Sorry, I have no answer for this. I will connect you with Agent.";
            var replyText = $"Bot: {responseText}";
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }
    }
}
