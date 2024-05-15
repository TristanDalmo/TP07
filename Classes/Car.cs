using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07.Classes
{
    internal class Car
    {
        private string model;

        private Engine engine; 
        private Driver driver; 
        private List<Wheel> wheels;
        public List<Wheel> Wheels
        { get { return wheels; } }
        private Trailer trailer;

        public Car(int power, string model, int nbWheels, int wheelSize)
        {
            this.model = model;
            this.engine = new Engine(power, this);

            this.wheels = new List<Wheel>();
            for (int i = 0; i < nbWheels; i++) // Pour le nombre de roues
            {
                this.wheels.Add(new Wheel(wheelSize)); // On ajoute une roue de taille "wheelSize"
            }
        }

        public Car (Car car)
        {
            this.model = car.model;
            this.engine = new Engine(car.engine.Power, this);

            this.wheels = new List<Wheel>();
            int nbWheels = car.wheels.Count;
            if (car.wheels.Count > 0) 
            {
                int wheelSize = car.Wheels[car.Wheels.Count-1].Size ;
                for (int i = 0; i < nbWheels; i++) // Pour le nombre de roues
                {
                    this.wheels.Add(new Wheel(wheelSize)); // On ajoute une roue de taille "wheelSize"
                }
            }
        }





        public void Fail()
        {
            engine.Fail();
        }

        public void Repair()
        {
            engine.Repair();
        }

        public void Start()
        {
            engine.Start();
        }

        public void Stop()
        {
            engine.Stop();
        }

        public void ChangeDriver(Driver driver )
        {
            this.driver = driver;
        }

        public void AttachTrailer( Trailer t)
        {
            this.trailer = t;
        }

        public void UntieTrailer()
        {
            this.trailer = null;
        }

        public override string ToString()
        {
            string s = "[Car] " + model + "\n"
                       + "->" + engine.ToString() + "\n"; // Engine toujours là donc on le met directement

            foreach (Wheel wheel in wheels)
            {
                s += "->" + wheel.ToString();
            }

            if (driver != null )
            {
                s += "\n->" + driver.ToString();
            }

            if (trailer != null)
            {
                s += "\n->" + trailer.ToString();
            }

            return s;        
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   model == car.model &&
                   (engine == car.engine) &&
                   (driver == car.driver) &&
                   (wheels == car.wheels) &&
                   (trailer == car.trailer);
        }
    }
}
