﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_TASK_2
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(Device? device) : base(device)
        {
        }

        public void mute()
        {
            // muelim burda mentiqsizlik var device pirivatedi ve bunun icinde fild yoxdu men nece device.secVolume(0) eliyim
        }
    }
}
