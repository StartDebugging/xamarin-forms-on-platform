using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.OnPlatform.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Device.OnPlatform(
                Android: () => LearnMoreButton.BackgroundColor = Color.Green,
                iOS: () => LearnMoreButton.BackgroundColor = Color.Orange,
                WinPhone: () => LearnMoreButton.BackgroundColor = Color.Purple,
                Default: () => LearnMoreButton.BackgroundColor = Color.Black);

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    LearnMoreButtonSwitch.BackgroundColor = Color.Green;
                    break;
                case Device.iOS:
                    LearnMoreButtonSwitch.BackgroundColor = Color.Orange;
                    break;
                case Device.UWP:
                    LearnMoreButtonSwitch.BackgroundColor = Color.Purple;
                    break;
                default:
                    LearnMoreButtonSwitch.BackgroundColor = Color.Black;
                    break;
            }
        }
    }
}