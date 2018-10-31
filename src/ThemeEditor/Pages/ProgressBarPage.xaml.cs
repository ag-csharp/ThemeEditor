﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ThemeEditor.Pages
{
    public class ProgressBarPage : UserControl
    {
        public ProgressBarPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}