﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;
using System.IO;

namespace BB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HashSet<string> filterList;
        List<string> bookmarkLinks = new List<string>();
        public MainWindow()
        {
            Init();

        }
        public void Init()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);
            Console.WriteLine("Deeznutsickles");

            
        }


        private void BookMarkControl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Added Bookmark");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Browser.Load($"https://www.google.com/search?q={SearchBox.Text}");
            }
            catch
            {

            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FindBox.Text.Length <= 0)
            {
                Browser.StopFinding(true);
            }
            else
            {
                Browser.Find(FindBox.Text, true, false, false);
            }
        }
    }
}
