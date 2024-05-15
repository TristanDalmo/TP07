using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07.Classes
{
    internal class Engine
    {
        private int power;
        public int Power 
        { get => power; }

        private bool isRunning;

        public bool IsRunning
        {
            set => isRunning = value;
            get => isRunning;
        }

        private bool failure;

        private Car car;

        public Engine(int power, Car car)
        {
            this.power = power;
            this.car = car;
        }

        public Engine (Engine engine, Car car)
        {
            this.power = engine.Power;
            this.car = car;
        }

        public void Start()
        {
            if (failure == false) isRunning = true;
        }

        public void Stop()
        {
            if (isRunning == true) isRunning = false;
        }

        public void Fail()
        {
            failure = true;
            isRunning = false;
        }

        public void Repair()
        {
            failure = false;
        }

        override public string ToString()
        {
            string s = "[Engine] power " + power;
            if (isRunning == true) s += ", running";
            else if (failure == true) s += ", failure";
            else s += ", stopped";

            return s;
        }

        public override bool Equals(object? obj)
        {
            return obj is Engine engine &&
                   power == engine.power &&
                   isRunning == engine.isRunning &&
                   failure == engine.failure &&
                   EqualityComparer<Car>.Default.Equals(car, engine.car);
        }
    }
}
