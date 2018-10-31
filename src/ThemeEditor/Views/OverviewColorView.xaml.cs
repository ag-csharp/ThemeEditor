﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ThemeEditor.Views
{
    public class OverviewColorView : UserControl
    {
        public OverviewColorView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
