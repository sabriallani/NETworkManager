﻿using NETworkManager.ViewModels.Applications;
using System.Windows.Controls;

namespace NETworkManager.Views.Applications
{
    public partial class SubnetCalculatorIPv4SplitterView : UserControl
    {
        private SubnetCalculatorIPv4SplitterViewModel viewModel = new SubnetCalculatorIPv4SplitterViewModel();

        public SubnetCalculatorIPv4SplitterView()
        {
            InitializeComponent();
            DataContext = viewModel;

            Dispatcher.ShutdownStarted += Dispatcher_ShutdownStarted;
        }

        private void Dispatcher_ShutdownStarted(object sender, System.EventArgs e)
        {
            viewModel.OnShutdown();
        }
    }
}
