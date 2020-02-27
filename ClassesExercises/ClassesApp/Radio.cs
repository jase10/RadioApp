using System;

namespace ClassesApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;


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

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the INSTRUCTIONS document in this solution   
}