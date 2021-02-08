using System;

namespace _2.Hospital
{
    class Program
    {
        static void Main(string[] args)

        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;

            int treatedPatientsForDay = 0;
            int treatedPatients = 0;
            int unTreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && treatedPatients < unTreatedPatients)
                {
                    doctors++;
                }
                if (patients == doctors)
                {
                 treatedPatientsForDay = doctors;
                    treatedPatients += treatedPatientsForDay;
                }
                else if (patients < doctors)
                {
                    treatedPatientsForDay = patients;
                    treatedPatients += treatedPatientsForDay;
                }

                else if (patients > doctors)
                {
                    treatedPatientsForDay = doctors;
                    treatedPatients += treatedPatientsForDay;
                    int unTreatedPatientsForDay = patients - treatedPatientsForDay;
                    unTreatedPatients += unTreatedPatientsForDay;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");


        }
    }
}
