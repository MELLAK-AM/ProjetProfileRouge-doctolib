using DoctolibWpfMvvM.Models;
using DoctolibWpfMvvM.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace DoctolibWpfMvvM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand PatientCommand { get; set; }
        public ICommand PraticienCommand { get; set; }  
        public ICommand RdvCommand { get; set; }


        public MainViewModel()
        {
            PatientCommand = new RelayCommand<StackPanel>((result) =>
            {
                result.Children.Clear();
                result.Children.Add(new PatientControl());
            });

            PraticienCommand = new RelayCommand<StackPanel>((result) =>
            {
                result.Children.Clear();
                result.Children.Add(new PraticienControl());
            });
            RdvCommand = new RelayCommand<StackPanel>((result) =>
            {
                result.Children.Clear();
                result.Children.Add(new RdvControl());
            });
        }

    }
}
