using System;

namespace EtoPlayground.Core.Models
{
    public interface IDialogService
    {
        void Notify(string msg, string title);
    }
}

