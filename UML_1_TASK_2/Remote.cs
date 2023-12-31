﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_2
{
    public class Remote
    {
        private Device? device;

        public Remote(Device? device)
        {
            this.device = device;
        }

        public void togglePower()
        {
            if(device!.isEnabled()) { 
                device!.disable();
            }
            else { device.enable(); }

        }
        
        public void volumeDown() {
            device!.setVolume(device!.getVolume()-1);
        }
        public void volumeUp() {
            device!.setVolume(device!.getVolume() + 1);
        }
        public void channelDown() {
            device!.setChannel(device!.getChannel() - 1); 
        }
        public void channelUp() {
            device!.setChannel(device!.getChannel() + 1);
        }


        public Device getDevice() { return device!; }
        public void setDevice(Device device) { this.device = device; }


    }
}
