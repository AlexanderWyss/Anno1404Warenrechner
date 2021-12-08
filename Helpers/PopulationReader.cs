using System;
using System.Diagnostics;

namespace Anno1404Warenrechner
{
    class PopulationReader
    {
        public static Population ReadPopulation(String processName)
        {
            var population = new Population();

            if (processName.EndsWith(".exe"))
            {
                processName = processName.Remove(processName.Length - 4);
            }

            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
                throw new Exception($"Could not find process with name: {processName}");
            var process = processes[0];

            long baseAddress = MemoryHelper.ReadAddressLong(process, GameAddresses.PopulationPointer);

            population.Beggars = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Beggars);
            population.Peasants = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Peasants);
            population.Citizens = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Citizens);
            population.Patricians = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Patricians);
            population.Noblemen = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Noblemens);
            population.Nomads = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Nomads);
            population.Envoys = MemoryHelper.ReadAddressInt(process, baseAddress + PopulationOffsets.Envoys);

            return population;
        }
    }
}