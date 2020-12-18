using DoctolibWpfMvvM.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DoctolibWpfMvvM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand PatientCommand { get; set; }
        public ICommand PraticienCommand { get; set; }


        public MainViewModel()
        {
           
        }

    }
}
