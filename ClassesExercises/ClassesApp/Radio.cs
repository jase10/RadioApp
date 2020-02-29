using Newtonsoft.Json;
using System;
using System.IO;

namespace ClassesApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        private int _volume = 0;
        string path = @"C:\Users\Jasey\Documents\RadioApp\ClassesExercises\status.txt";

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
            
           
            bool isOn = _on;
            int channelNumber = _channel;
            
            if (isOn == true)
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

        public int volumeControl() 
        {
            
            return _volume;
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
            string jsonfile = File.ReadAllText(path);
            Radio info = JsonConvert.DeserializeObject<Radio>(jsonfile);
            Channel = info.Channel;
            Volume = info.Volume;
            
        }


    }
}