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

/*
 * Daniel Bruce
 * 5/3/2022
 * This program tracks the distance a jellyfish has moved at consistent time intervals (the distance is actually a randomly generated number)
 * A short history of collected data, and unit conversion features are available.
 */

namespace DataCollector
{

    public sealed partial class MainPage : Page
    {
		private MeasureLengthDevice jellyfishMovement = new MeasureLengthDevice(Unit.Imperial);//default unit is imperial
		private Queue<string> measureHistory = new Queue<string>();

		public MainPage()
        {
            this.InitializeComponent();
			//the initial data binding
			//historyDataBinding();
			this.jellyfishMovement.timeData.Tick+= measurmentTextUpdateHandler;
			historyListView.ItemsSource = this.measureHistory;
			historyListView.Visibility= Visibility.Collapsed;
		}
		//enables & disables collection respectively
		private void collectToggleButton_Checked(object sender, RoutedEventArgs e)
		{
			this.jellyfishMovement.StartCollecting();
		}

		private void collectToggleButton_Unchecked(object sender, RoutedEventArgs e)
		{
			this.jellyfishMovement.StopCollecting();
		}
		//toggle that makes the history visible
		private void displayHistoryToggleButton_Checked(object sender, RoutedEventArgs e)
		{
			historyListView.Visibility = Visibility.Visible;
		}

		private void displayHistoryToggleButton_Unchecked(object sender, RoutedEventArgs e)
		{
			historyListView.Visibility = Visibility.Collapsed;
		}
		//Update measurements
		private void measurmentTextUpdateHandler(object sender, object e)
		{
			//recent measurement
			recentMeasurementTextBox.Text = this.jellyfishMovement.mostRecentMeasure.ToString();
			//history
			historyDataBinding();
			//converted measurment
			if (jellyfishMovement.unitsToUse == Unit.Imperial)
			{
				convertedMeasurementTextBox.Text = Math.Round(this.jellyfishMovement.MetricValue(),4).ToString();
			}
			else {
				convertedMeasurementTextBox.Text = Math.Round(this.jellyfishMovement.ImperialValue(),4).ToString();
			}
		}
		//format raw data and bind historylistview to the formatted data
		private void historyDataBinding() {
			int qLength = this.measureHistory.Count + 1;
			string record = "";
			//dequeue so that things don't break
			if (qLength > 10)
			{
				this.measureHistory.Dequeue();
			}
			
			//add raw data to record string
			record += this.jellyfishMovement.GetRawData()[this.measureHistory.Count].ToString();
			
			//add units of measurement
			if (jellyfishMovement.unitsToUse == Unit.Imperial)
			{
				record += '″';
			}
			else {
				record += " cm";
			}

			//add time stamp
			record += (" Time: " + DateTime.Now);
			//add record to queue
			this.measureHistory.Enqueue(record);
			//update display with queue data
			historyListView.ItemsSource = this.measureHistory.ToArray<string>().Reverse();
			
		}

		private void inchesRadioButton_Checked(object sender, RoutedEventArgs e)
		{
			this.jellyfishMovement.setUnit(Unit.Imperial);
		}

		private void centimetersRadioButton_Checked(object sender, RoutedEventArgs e)
		{
			this.jellyfishMovement.setUnit(Unit.Metric);
		}
	}
}
