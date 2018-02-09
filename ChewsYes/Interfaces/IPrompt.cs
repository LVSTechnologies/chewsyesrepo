using System;
using System.Threading.Tasks;

namespace ChewsYes.Interfaces
{
    public interface IPrompt
    {
        Task<string> DisplayPrompt(string title, string message);
    }
}
