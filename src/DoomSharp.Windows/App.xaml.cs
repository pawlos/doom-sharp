﻿using System.Windows;
using DoomSharp.Core;
using DoomSharp.Core.Data;
using DoomSharp.Windows.Data;
using DoomSharp.Windows.ViewModels;

namespace DoomSharp.Windows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DoomGame.SetConsole(ConsoleViewModel.Instance);
            DoomGame.SetOutputRenderer(MainViewModel.Instance);
            WadFileCollection.Init(new WadStreamProvider());
        }
    }
}
