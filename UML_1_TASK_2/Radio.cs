using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_2
{
    public class Radio : Device
    {
        int channel;
        int percent;
        bool isde = false;

        public void disable()
        {
            isde = true;
        }

        public void enable()
        {
            isde= false;
        }

        public int getChannel()
        {
            return channel;
        }

        public int getVolume()
        {
            return percent;
        }

        public bool isEnabled()
        {
            if(isde) { return true; } return false; 
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int percent)
        {
            this.percent = percent;
        }
    }
}
