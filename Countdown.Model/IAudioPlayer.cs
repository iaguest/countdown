﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown.Model
{
    public interface IAudioPlayer
    {
        void Initialise();

        void OnStart();

        void OnStop();
    }
}