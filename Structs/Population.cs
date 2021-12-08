using System;

namespace Anno1404Warenrechner
{
    struct Population
    {
        public int Beggars;

        public int Peasants;
        public int Citizens;
        public int Patricians;
        public int Noblemen;

        public int Nomads;
        public int Envoys;
        public override string ToString()
        {
            return $"Beggars: {Beggars}, Peasants: {Peasants}, Citizens: {Citizens}, Patricians: {Patricians}, Nobelman: {Noblemen}, Nomads: {Nomads}, Envoys: {Envoys}";
        }
    }
}