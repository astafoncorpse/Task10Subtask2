using Task10Subtask2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task10Subtask2
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Калькулятор начал свою работу");
            
            
        }
    }
}