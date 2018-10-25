using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Exam_uwp.view
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowFile : Page
    {
        public ShowFile()
        {
            this.InitializeComponent();
            showFile();
        }
        private async void showFile()
        {
            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.GetFileAsync("test.txt");
            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            Debug.WriteLine(text);
        }
    }
}
