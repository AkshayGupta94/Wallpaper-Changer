using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Threading.Tasks;
using Windows.Phone.System.UserProfile;

namespace PhoneClassLibrary2
{
    public static class Class1
    {
        public async static Task setImageAsLockscreen()
        {
            Random rndNumber = new Random();
            int a = rndNumber.Next(1, 15);
            string lolol = a.ToString() + ".jpg";
            await SetLockScreen(lolol);

        }
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
    }
}
