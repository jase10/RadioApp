using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        private int _volume = 0;
        string path = @"C:\Users\Jasey\Documents\RadioApp\ClassesExercises\WpfApp1\status.json";

      public bool On 
        {
            get { return _on; }
            set { _on = value; }
        }
       public int readChannel 
        {
            get
            {
                return _channel;
            }

            set
            {
                if (value <= 4 && value > 0)
                {
                    _channel = value;
                }


            }
        }

        public int readVolume
        {
            get { return _volume; }
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _volume = value;
                }
            }
        }
        public int Channel
        {
            get
            {
                return _channel;
            }

            set 
            {
                if ( value <= 4 && value > 0 && _on == true)
                {
                    _channel = value;
                }
        
               
            }
        }

        public int Volume 
        {
            get { return _volume;  }
            set { if (value >= 0 && value <= 30 && _on == true) 
                { 
                    _volume = value; 
                }
            }
        }


        public void TurnOn()
        {
            _on = true;
          
            
        }

       

        public string Play()
        {
           
            int channelNumber = _channel;
           
            if (_on == true)
            {
                return $"Playing channel {channelNumber}";
            }
            else 
            {
                return "Radio is off";
            }
           
            
        }
            public void TurnOff()
            {
            _on = false;

            }

        

        public void Write() 
        {
           
            _channel = Channel;
            _volume = Volume;
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, output);
        }

        public void Read()
        {
            

            string rfile = File.ReadAllText(path);
            Radio r = JsonConvert.DeserializeObject<Radio>(rfile);
            Channel = r.readChannel;
            Volume = r.readVolume;
            
            
        }


    }
}