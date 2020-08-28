using Ifes.Services;
using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Ifes.Views.Aircrew
{
    public sealed partial class PassengersManagment : Page
    {
        public PassengersManagment()
        {
            this.SelectedSeat = null;
            this.InitializeComponent();
        }

        public Seat SelectedSeat { get; set; }


        public async System.Threading.Tasks.Task LoadDataAsync()
        {
            if (PlaneService.Instance.Seats.Count == 0)
            {
                await PlaneService.Instance.LoadPassengers();
            }


        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await LoadDataAsync();
            RenderVisual();
        }


        private void RenderVisual()
        {
            var seats = PlaneService.Instance.Seats;
            var seatsForGrid = new ArrayList();

            foreach (var seat in seats)
            {
                seatsForGrid.Add(seat);
                if (seat.Col == "C")
                {
                    seatsForGrid.Add(new Seat { Row = seat.Row,Col = "" });
                }
            }
            FlatGround.ItemsSource = seatsForGrid;
        }

        private async void FlatGround_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (((Seat)e.ClickedItem).Col == "")
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Invalid seat",
                    Content = "The aisle is not a  valid seat",
                    CloseButtonText = "Ok"
                };

                await contentDialog.ShowAsync();
                return;
            }
            
            this.SelectedSeat =(Seat) e.ClickedItem;
            RenderSelectedPerson();
        }

        private void RenderSelectedPerson()
        {
            TxtClass.Text = $"Row number: {SelectedSeat.Row} Place: {SelectedSeat.Col} ";
            TxtName.Text = SelectedSeat.Passenger.UserName;
            TxtSelectedSeat.Text = SelectedSeat.ToString();
            
        }
    }
}
