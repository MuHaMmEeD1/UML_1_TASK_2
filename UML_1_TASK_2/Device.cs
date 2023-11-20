using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_2
{
    public interface Device
    {
        bool isEnabled();
        void enable();
        void disable();
        int getVolume();
        void setVolume(int percent);
        int getChannel();
        void setChannel(int channel);
    }
}
