﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EtoPlayground.Core.Models
{
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        protected NotificationObject()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var h = this.PropertyChanged;
            if (h != null)
                h(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T store, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(store, value))
                return false;

            store = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}

