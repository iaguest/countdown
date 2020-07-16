﻿using System;

namespace Countdown.Model
{
    public interface IGame
    {
        string InitializeMessage { get; }
        string StartRunMessage { get; }
        string GameBoard { get; }
        string EndRunMessage { get; }

        bool Initialize(string input);
        void Run(Action onDone);
        int GetScore(string answer);

    }
}