using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Windows.UI.Xaml;//for dispatch timer



//This "device" tracks various length measurments in a table

namespace DataCollector
{
    class MeasureLengthDevice : Device, IMeasuringDevice
    {
        //Constants
        private const int MAX_QUEUE_LENGTH = 10;
        private const decimal INCH_CENTIMETER_CONVERSION = 2.54m;

        //collections
        private Queue<int> dataCaptured = new Queue<int>();

        //properties														 
		private int _mostRecentMeasure;
        public int mostRecentMeasure
        {
            get => this._mostRecentMeasure;
            private set => this._mostRecentMeasure = value;
        }
        private DispatcherTimer _timeData = new DispatcherTimer(); //this will be used in mainpage.xaml.cs, but we need to control collection through the object, so it's here
        public DispatcherTimer timeData { 
            get => _timeData; 
            private set => _timeData = value; 
        }
        private Unit _unitsToUse;//determines base units
        public Unit unitsToUse { 
            get => _unitsToUse; 
            private set => _unitsToUse = value; 
        }


		//constructor
		public MeasureLengthDevice(Unit u) {
            this.unitsToUse = u;
            this.timeData.Tick += captureData;//subscribe tick event to captureData
        }

        //methods
        public void setUnit(Unit u)
        {
            this.unitsToUse = u;
        }
        //Adds data to the dataCaptured queue when the timer ticks
        public void captureData(object sender, object e) {

            int d = GetMeasurement();
            this.mostRecentMeasure = d;
            //add data to queue and remove old data from queue if needed (max length 10)
            dataCaptured.Enqueue(d);
            if (dataCaptured.Count > MAX_QUEUE_LENGTH) {
                dataCaptured.Dequeue();
            }
        }

        //interface-loaned methods
        public int[] GetRawData()
        {
            //this passes the array by reference, but we aren't changing any values when we use this, so this should be fine
            return this.dataCaptured.ToArray<int>();
        }
        //displays imperial and metric values respectively, regardless of what the base units are
        public decimal ImperialValue()
        {
            if (unitsToUse == Unit.Imperial)
            {
                return this.mostRecentMeasure;
            }
            else {
                return this.mostRecentMeasure * INCH_CENTIMETER_CONVERSION;
            }
        }

        public decimal MetricValue()
        {
            if (unitsToUse == Unit.Metric)
            {
                return this.mostRecentMeasure;
            }
            else
            {
                return this.mostRecentMeasure / INCH_CENTIMETER_CONVERSION;
            }
        }
        //activates and deactivates the timer respectively
        public void StartCollecting()
        {
            TimeSpan measInterv = new TimeSpan(0,0,3); //tick every 3 seconds. You can pretend this is the fastest 15 seconds of your life if you want.
            this.timeData.Interval = measInterv;
            this.timeData.Start();
        }

        public void StopCollecting()
        {
            this.timeData.Stop();
        }

        
    }
}
