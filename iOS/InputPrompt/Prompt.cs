using System;
using System.Threading.Tasks;
//using ChewsYes.Interfaces;
using UIKit;

namespace ChewsYes.iOS.InputPrompt
{
    public class Prompt
    {
        public Prompt()
        {
        }

        public Task<string> DisplayPrompt(string title, string message)
        {
            var ret = new TaskCompletionSource<string>();

            UIAlertView alert = new UIAlertView(title, message, null, "", "OK");
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;

            alert.Clicked += (sender, e) => {
                ret.SetResult(alert.GetTextField(0).Text);
            };

            alert.Show();

            return ret.Task;
        }
    }
}
