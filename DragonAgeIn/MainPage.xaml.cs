using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Phone.System.UserProfile;
using DragonAgeIn.Resources;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;

namespace DragonAgeIn
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            Loaded += MainPage_Loaded;
            BuildLocalizedApplicationBar();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Uri test = new Uri("/da3/1.jpg", UriKind.Relative);
            //BitmapImage imagetosave = new System.Windows.Media.Imaging.BitmapImage(test);
            //using(var isoStore= IsolatedStorageFile.GetUserStoreForApplication())
            //{
            //    var wb = new WriteableBitmap(imagetosave);
            //    using (var isoFileStream=isoStore.CreateFile("1.jpg"))
            //    {
            //        Extensions.SaveJpeg(wb, isoFileStream, wb.PixelWidth, wb.PixelHeight, 0, 100);
            //    }
            //}
            for(int i=1;i<=15;i++)
            {
            var uri = new Uri("da3\\"+i.ToString()+".jpg", UriKind.Relative);
            var sri = Application.GetResourceStream(uri);
            var data = sri.Stream;
            IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();
            try
            {
                using (IsolatedStorageFileStream stream = storage.CreateFile("Shared\\ShellContent\\" + i.ToString() + ".jpg"))
                {
                    data.CopyTo(stream);
                }
            }
            catch
             {
 
             }
            }
        }

      

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/ApplicationBar.Check.png", UriKind.Relative));
            appBarButton.Text = "Set As Lockscreen";
            appBarButton.Click += appBarButton_Click;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            //ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            //ApplicationBar.MenuItems.Add(appBarMenuItem);
        }

        private async void appBarButton_Click(object sender, EventArgs e)
        {
            //using(var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            //{
            //    using(var isoFileStream = isoStore.OpenFile("1.jpg",System.IO.FileMode.Open))
            //    {
            //        int a;
            //       // await SetLockScreen(isoFileStream);
            //    }
            //}
            await SetLockScreen("1.jpg");
        }

        //private Task SetLockScreen(IsolatedStorageFileStream isoFileStream)
        //{
        //    throw new NotImplementedException();
        //}

        public static async Task SetLockScreen(string fileName)
        {
            bool hasAccessForLockScreen
               = LockScreenManager.IsProvidedByCurrentApplication;
            if (!hasAccessForLockScreen)
            {

                var accessRequested = await LockScreenManager.RequestAccessAsync();
                hasAccessForLockScreen = (accessRequested == LockScreenRequestResult.Granted);
            }

            if (hasAccessForLockScreen)
            {
                Uri imgUri = new Uri(
                     "ms-appdata:///local/" + "Shared\\ShellContent\\" + fileName,
                     UriKind.Absolute);
                LockScreen.SetImageUri(imgUri);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lol("/da3/1.jpg");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lol("/da3/2.jpg");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lol("/da3/3.jpg");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lol("/da3/4.jpg");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lol("/da3/5.jpg");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lol("/da3/6.jpg");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lol("/da3/7.jpg");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            lol("/da3/8.jpg");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            lol("/da3/9.jpg");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            lol("/da3/10.jpg");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            lol("/da3/11.jpg");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            lol("/da3/12.jpg");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            lol("/da3/13.jpg");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            lol("/da3/14.jpg");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            
            
        }
        private void lol(string lol)
        {
            Top.Text = "Tap on the image to go back";
            MyButton.Visibility = System.Windows.Visibility.Visible;
            MyGrid.Opacity = 0.0;
            MyGrid.Visibility = System.Windows.Visibility.Collapsed;
            MyScroll.Visibility = System.Windows.Visibility.Collapsed;
            MainImage.Source = new BitmapImage(new Uri(lol, UriKind.Relative));
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            lol("/da3/15.jpg");
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Top.Text = "Dragon Age Inquisition";
            MyButton.Visibility = System.Windows.Visibility.Collapsed;
            MyGrid.Opacity = 1.0;
            MyGrid.Visibility = System.Windows.Visibility.Visible;
            MyScroll.Visibility = System.Windows.Visibility.Visible; 
        }
    }
}