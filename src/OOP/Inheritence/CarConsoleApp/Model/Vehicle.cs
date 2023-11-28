namespace CarConsoleApp.Model
{
    abstract class Vehicle
    {
        public string Name;
        public byte CurrentSpeed;
        public byte MaxPassengerQuantity;
        public string Color;
    }

    abstract class Car : Vehicle
    {
        protected bool isStarted;

        public virtual void Start()   // virtual - umożliwia zastosowanie mechanizmu poliformizmu
        {
            isStarted = true;
            Console.WriteLine("Started.");
        }

        // Brak poliformizmu - metoda jest ustalana na etapie kompilacji

        // Poliformizm (wielopostaciowość) - metoda jest ustalana w trakcie działania aplikacji (runtime)

        // Musimy oznaczyć metodę jako wirtualną (virtual)
        // a w klasie pochodnej użyć słówka override aby zmienić jej implementację

        // użycie: w przypadku gdy na etapie pisania aplikacji nie jesteśmy w stanie określić jednoznacznie typu
        // np. czy samochód jest elektryczny czy spalinowy


    }

    class PetrolCar : Car
    {
        public int EngineCapacity;

        public decimal FluelLevel;

        public void Refuel()
        {
           
        }

        public override void Start()
        {
            if (FluelLevel > 0)
                base.Start();
        }
    }

    // W języku C# możemy dziedziczyć tylko z jednej(!) klasy
    class ElectricCar : Car
    {
        public float BateryLevel;

        public ElectricCar()
        {
            BateryLevel = 1.0f;
        }

        public override void Start()
        {
            if (BateryLevel > 0)
                base.Start();
        }

        public void Charge()
        {
            BateryLevel = BateryLevel + BateryLevel * 0.1f;
        }
    }

    class Truck : Car
    {
        public string Cargo;
    }

    class Bicycle : Vehicle
    {
    }

    class ElectricBicycle : Bicycle
    {
        public float BateryLevel;

        public void Charge()
        {
            BateryLevel = BateryLevel + BateryLevel * 0.1f;
        }

    }


}
