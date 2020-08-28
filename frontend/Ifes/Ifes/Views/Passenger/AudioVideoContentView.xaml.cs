using Ifes.ViewModels;
using System;
using System.Collections.Generic;
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
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ifes.Views.Passenger {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AudioVideoContentView : Page {
        public AudioVideo AudioVideo { get; set; }

        bool playing;


        public AudioVideoContentView() {
            this.InitializeComponent();
            TextBlockDescription.Text = "Please select an item for more details.";
            playing = false;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);
            AudioVideo = (AudioVideo)e.Parameter;
        }

        private void OnItemClick(object sender, ItemClickEventArgs e) {
            AudioVideo.CurrentItem = (CatalogItem)e.ClickedItem;

            BtnPlay.IsEnabled = true;
            mediaPlayer.Source = null;
            playing = false;
        }

        private async void OnBtnPlayClick(object sender, RoutedEventArgs e) {
            mediaPlayer.Source = null;
            Windows.Storage.IStorageFile file = null;
            Windows.Storage.StorageFolder folder =
                await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            if(AudioVideo.Title.ToLower() == "audio") {
              file = await folder.GetFileAsync($"{AudioVideo.CurrentItem.Name.ToLower()}.mp3");
            }
            else {
             file = await folder.GetFileAsync($"{AudioVideo.CurrentItem.Name.ToLower()}.mp4");
            }


            mediaPlayer.AutoPlay = false;
            mediaPlayer.AreTransportControlsEnabled = true;

            mediaPlayer.Source = MediaSource.CreateFromStorageFile(file);

            if (playing) {
                mediaPlayer.Source = null;
                playing = false;

            } else {
                mediaPlayer.MediaPlayer.Play();
                playing = true;

            }

        }
    }
}
