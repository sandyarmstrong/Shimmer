﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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
using ReactiveUI;
using Shimmer.Client.WiXUi;
using Shimmer.WiXUi.ViewModels;

namespace Shimmer.WiXUi.Views
{
    /// <summary>
    /// Interaction logic for InstallingView.xaml
    /// </summary>
    public partial class InstallingView : UserControl, IViewFor<InstallingViewModel>
    {
        public InstallingView()
        {
            InitializeComponent();

            this.OneWayBind(ViewModel, x => x.LatestProgress, x => x.ProgressValue.Value);
        }

        public InstallingViewModel ViewModel {
            get { return (InstallingViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(InstallingViewModel), typeof(InstallingView), new PropertyMetadata(null));

        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (InstallingViewModel) value; }
        }
    }
}
