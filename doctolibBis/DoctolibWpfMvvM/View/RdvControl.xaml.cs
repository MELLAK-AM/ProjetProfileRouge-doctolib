using DoctolibWpfMvvM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoctolibWpfMvvM.View
{
    /// <summary>
    /// Logique d'interaction pour RdvControl.xaml
    /// </summary>
    public partial class RdvControl : UserControl
    {
        public RdvControl()
        {
            InitializeComponent();
            DataContext = new RdvViewModel();
            
        }
    }
}
