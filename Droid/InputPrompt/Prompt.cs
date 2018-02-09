using System;
using System.Threading.Tasks;
using Android.App;
using Android.Views.InputMethods;
using Android.Widget;
using ChewsYes.Interfaces;
using Xamarin.Forms;

namespace ChewsYes.Droid.InputPrompt
{
    public class Prompt : IPrompt
    {
        public Prompt()
        {
        }

        public Task<string> DisplayPrompt(string title, string message)
        {
            var ret = new TaskCompletionSource<string>();

            //EditText et = new EditText();
            var ad = new AlertDialog.Builder(Forms.Context);
            EditText editText = new EditText(Forms.Context);
            //ad.Context = ActivationContext;
            ad.SetTitle("Orders");
            ad.SetView(editText);
            ad.SetCancelable(false);
            ad.SetPositiveButton("Ok",(sender, e) => {
              ret.SetResult(editText.Text);  
            });
            ad.Show();

            return ret.Task;
        }

    }
}
