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
using System.Threading.Tasks;
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


        private void RenderDropDowns()
        {
            var seats = PlaneService.Instance.Seats;
            DropDownFirst.ItemsSource = seats;
            DropDwnSecond.ItemsSource = seats;
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
                    seatsForGrid.Add(new Seat { Row = seat.Row, Col = "" });
                }
            }
            FlatGround.ItemsSource = seatsForGrid;
            RenderDropDowns();

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
            DropDownFirst.SelectedItem = (Seat)e.ClickedItem;
            this.SelectedSeat = (Seat)e.ClickedItem;
            RenderSelectedPerson();
        }

        private void RenderSelectedPerson()
        {
            TxtSelectedSeat.Text= $"Row number: {SelectedSeat.Row} Place: {SelectedSeat.Col} ";
            TxtName.Text = SelectedSeat.Passenger.UserName;
            TxtClass.Text = SelectedSeat.FlightClass.ToString();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var firstOption = (Seat)DropDownFirst.SelectedItem;
            var secondOption = (Seat)DropDwnSecond.SelectedItem;

            if (firstOption == null || secondOption == null)
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Selection invalid",
                    Content = "Please select a value ",
                    CloseButtonText = "Ok"
                };

                await contentDialog.ShowAsync();
                return;
            }
            if (firstOption.Id == secondOption.Id)
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Selection invalid",
                    Content = "What purpose does it serve to switch the same seats?",
                    CloseButtonText = "Ok"
                };

                await contentDialog.ShowAsync();
                return;
            }
            await PlaneService.Instance.Switchseat(firstOption,secondOption);
            await PlaneService.Instance.LoadPassengers();
            await PassengersService.Instance.LoadPassengers();
        }
    }
}
