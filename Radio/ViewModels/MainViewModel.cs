using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace Radio
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { LineOne = "Classic Rock FM", LineTwo = "http://www.rock.lt/", LineThree = "http://5.20.223.18:80/crf32.aac" });
            this.Items.Add(new ItemViewModel() { LineOne = "European Hit Radio", LineTwo = "http://www.europeanhitradio.lt/", LineThree = "http://84.46.204.45:8000/ehr" });
            this.Items.Add(new ItemViewModel() { LineOne = "Extra FM", LineTwo = "http://www.extrafm.lt/", LineThree = "http://82.135.234.194/ExtraFM" });
            this.Items.Add(new ItemViewModel() { LineOne = "FM99", LineTwo = "http://www.fm99.lt/", LineThree = "http://82.135.234.194/FM99" });
            this.Items.Add(new ItemViewModel() { LineOne = "Geras FM", LineTwo = "http://www.gerasfm.lt/", LineThree = "http://82.135.234.194/GerasFM" });
            this.Items.Add(new ItemViewModel() { LineOne = "Jazz FM", LineTwo = "http://www.jazzfm.lt/", LineThree = "mms://mms.skynet.lt/JazzFM128" });
            this.Items.Add(new ItemViewModel() { LineOne = "Kelyje (Kaunas)", LineTwo = "http://www.radijaskelyje.lt/", LineThree = "http://82.135.234.194/KelyjeKaunas" });
            this.Items.Add(new ItemViewModel() { LineOne = "Kelyje (Klaipėda)", LineTwo = "http://www.radijaskelyje.lt/", LineThree = "http://82.135.234.194/KelyjeKlaipeda" });
            this.Items.Add(new ItemViewModel() { LineOne = "Kelyje (Vilnius)", LineTwo = "http://www.radijaskelyje.lt/", LineThree = "http://82.135.234.194/KelyjeVilnius" });
            this.Items.Add(new ItemViewModel() { LineOne = "Laluna", LineTwo = "http://www.laluna.lt/", LineThree = "http://84.46.147.81/laluna/mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "Lietus", LineTwo = "http://www.lietus.fm/", LineThree = "http://84.46.147.81:80/lietus/mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "M-1", LineTwo = "http://www.m-1.fm/", LineThree = "http://84.46.147.81:80/m1/aacp" });
            this.Items.Add(new ItemViewModel() { LineOne = "M-1 Plius", LineTwo = "http://pliusas.fm/", LineThree = "http://84.46.147.81/laluna/mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "Marijos Radijas", LineTwo = "http://www.marijosradijas.lt/", LineThree = "http://streamer.marijosradijas.lt:8001/marijosradijas.mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "Neringa FM", LineTwo = "http://neringafm.lt/", LineThree = "http://streamer.midiaudio.com/ner" });
            this.Items.Add(new ItemViewModel() { LineOne = "Power Hit Radio", LineTwo = "http://www.powerhitradio.lt/", LineThree = "http://powerhitradio.lt:8000/PHR" });
            this.Items.Add(new ItemViewModel() { LineOne = "Pūkas", LineTwo = "http://www.pukas.lt/", LineThree = "mms://82.135.234.195/pukas" });
            this.Items.Add(new ItemViewModel() { LineOne = "Radiocentras", LineTwo = "http://rc.lt/", LineThree = "http://84.46.205.13:80/rc32.aac" });
            this.Items.Add(new ItemViewModel() { LineOne = "Rap.lt", LineTwo = "http://www.rap.lt/", LineThree = "http://77.241.194.224:8000/" });
            this.Items.Add(new ItemViewModel() { LineOne = "Relax FM", LineTwo = "http://www.relaxfm.lt/", LineThree = "http://5.20.223.18:80/relaxfm32.aac" });
            this.Items.Add(new ItemViewModel() { LineOne = "RS2", LineTwo = "http://www.rs2.lt/", LineThree = "http://rs2.lt:8000/rs2.lt.aac" });
            this.Items.Add(new ItemViewModel() { LineOne = "Saulės radijas", LineTwo = "http://www.saulesradijas.lt/", LineThree = "http://server.superstore.lt:8000/stream.mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "TAU", LineTwo = "http://www.tau.lt/", LineThree = "http://radijas.tau.lt:8000/stream" });
            this.Items.Add(new ItemViewModel() { LineOne = "ZIP FM", LineTwo = "http://www.zipfm.lt/", LineThree = "http://84.46.205.13/zipfm64.mp3" });
            this.Items.Add(new ItemViewModel() { LineOne = "Žinių radijas", LineTwo = "http://www.ziniuradijas.lt/", LineThree = "http://netradio.ziniur.lt:8000/ziniur.mp3" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}