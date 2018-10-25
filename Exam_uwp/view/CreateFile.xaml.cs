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
    public sealed partial class CreateFile : Page
    {
        public CreateFile()
        {
            this.InitializeComponent();
        }

        private async void BtnSignup_Click(object sender, RoutedEventArgs e)
        {
            // Create sample file; replace if exists.
            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.CreateFileAsync(Name.Text,
                    Windows.Storage.CreationCollisionOption.ReplaceExisting);

            
            Windows.Storage.StorageFile getFile =
                await storageFolder.GetFileAsync(Name.Text);
            await Windows.Storage.FileIO.WriteTextAsync(getFile, Content.Text);
            Debug.WriteLine("OKe");
        }
    }
}
