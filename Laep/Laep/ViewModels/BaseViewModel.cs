﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Laep.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {       
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private bool _tabBarIsVisible;
        public bool TabBarIsVisible
        {
            get => _tabBarIsVisible;
            set => SetProperty(ref _tabBarIsVisible, value);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected void SetProperty<T>(ref T storege, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storege, value))
                return;

            storege = value;
            OnPropertyChanged(propertyName);
        }
    }
}
