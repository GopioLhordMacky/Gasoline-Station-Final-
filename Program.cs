using Gasoline_Station;
using System;
namespace GasolineStation
{
    class GasolineStation
    {

        public static void Main(string[] args)
        {
            int GasLoop = 100;
            int Stop = 0;
            List<double> DieselGasEarned = new List<double>();
            List<double> PremiumGasEarned = new List<double>();
            List<double> GasolineGasEarned = new List<double>();
            List<double> KeroseneGasEarned = new List<double>();
            List<double> UnleadedGasEarned = new List<double>();
            List<double> PetrolGasEarned = new List<double>();
            while (GasLoop > Stop)
            {
                Console.Write("\nGas (1), Inventory (2), Exit (3) = ");
                int Choices = Convert.ToInt32(Console.ReadLine());


                switch (Choices)
                {
                    case 1:// Gas
                        Console.WriteLine("\n1. Diesel");
                        Console.WriteLine("2. Premium");
                        Console.WriteLine("3. Gasoline");
                        Console.WriteLine("4. Unleaded");
                        Console.WriteLine("5. Kerosene");
                        Console.WriteLine("6. Petrol");
                        Console.Write("\nEnter the number corresponding to your fuel type: ");
                        int fuel = Convert.ToInt32(Console.ReadLine());
                        double amountDiesel = 0;
                        double amountPremium =0;
                        double amountGasoline=0;
                        double amountUnleaded = 0;
                        double amountKerosene = 0;
                        double amountPetrol = 0;
                        switch (fuel)
                        {

                            case 1: // Diesel
                                Console.Write($"\nHow much Diesel Fuel?: ");
                                amountDiesel = Convert.ToInt32(Console.ReadLine());
                                DieselGasEarned.Add(amountDiesel);
                                FuelType.Diesel(amountDiesel);

                                break;
                            case 2: // Premium
                                Console.Write("\nHow much Premium Fuel?: ");
                                amountPremium = Convert.ToInt32(Console.ReadLine());
                                PremiumGasEarned.Add(amountPremium);
                                FuelType.Premium(amountPremium);
                                break;
                            case 3: // Gasoline
                                Console.Write("\nHow much Gasoline Fuel?: ");
                                amountGasoline = Convert.ToInt32(Console.ReadLine());
                                GasolineGasEarned.Add(amountGasoline);
                                FuelType.Gasoline(amountGasoline);
                                break;
                            case 4:// Unleaded
                                Console.Write("\nHow much Unleaded Fuel?: ");
                                amountUnleaded = Convert.ToInt32(Console.ReadLine());
                                UnleadedGasEarned.Add(amountUnleaded);
                                FuelType.Unleaded(amountUnleaded);
                                break;
                            case 5: // Kerosene
                                Console.Write("\nHow much Kerosene Fuel?: ");
                                amountKerosene = Convert.ToInt32(Console.ReadLine());
                                KeroseneGasEarned.Add(amountKerosene);
                                FuelType.Kerosene(amountKerosene);
                                break;
                            case 6: // Petrol
                                Console.Write("\nHow much Petrol Fuel?: ");
                                amountPetrol = Convert.ToInt32(Console.ReadLine());
                                PetrolGasEarned.Add(amountPetrol);
                                FuelType.Petrol(amountPetrol);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2: // Exit
                      
                        Console.WriteLine("1. Diesel");
                        Console.WriteLine("2. Premium");
                        Console.WriteLine("3. Gasoline");
                        Console.WriteLine("4. Unleaded");
                        Console.WriteLine("5. Kerosene");
                        Console.WriteLine("6. Petrol");
                        Console.Write("What gas type do you want to check?: ");
                        double gas = Convert.ToInt32(Console.ReadLine());
                        double DieselAmounts = 0;
                        // FuelType.DieselAmount();
                        amountDiesel = 0;
                          amountPremium = 0;
                         amountGasoline = 0;
                         amountUnleaded = 0;
                         amountKerosene = 0;
                         amountPetrol = 0;
                        switch (gas)
                        {
                            case 1:
                                double DieselMarketPrice = 54.06;
                                double DieselEarned = 0;
                                foreach (var DieselEarning in DieselGasEarned)
                                {
                                    DieselEarned += DieselEarning;
                                }
                                double DieselTotalEarnings = DieselEarned / DieselMarketPrice;
                                Console.WriteLine($"Your total earning for Diesel is {DieselEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double DieselRefill = Convert.ToInt32(Console.ReadLine());
                                double RefillLiter = DieselRefill / DieselMarketPrice;
                                Console.WriteLine($"You can refill {RefillLiter} liters of Diesel");
                                break;
                            case 2:
                                double PremiumMarketPrice = 59.06;
                                double PremiumEarned = 0;
                                foreach (var PremiumEarning in PremiumGasEarned)
                                {
                                    PremiumEarned += PremiumEarning;
                                }
                                Console.WriteLine($"Your total earning for Diesel is {PremiumEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double PremiumRefill = Convert.ToInt32(Console.ReadLine());
                                double PremiumLiter = PremiumRefill / PremiumMarketPrice;
                                Console.WriteLine($"You can refill {PremiumLiter} liters of Diesel");
                                break;
                            case 3:
                                double GasolineMarketPrice = 58.05;
                                double GasolineEarned = 0;
                                foreach (var GasolineEarning in GasolineGasEarned)
                                {
                                    GasolineEarned += GasolineEarning;
                                }
                                Console.WriteLine($"Your total earning for Diesel is {GasolineEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double GasolineRefill = Convert.ToInt32(Console.ReadLine());
                                double GasolineLiter = GasolineRefill / GasolineMarketPrice;
                                Console.WriteLine($"You can refill {GasolineLiter} liters of Diesel");
                                break;
                            case 4:
                                double KeroseneMarketPrice = 58.05;
                                 double KeroseneEarned = 0;
                                foreach (var KeroseneEarning in KeroseneGasEarned)
                                {
                                    KeroseneEarned += KeroseneEarning;
                                }
                                Console.WriteLine($"Your total earning for Diesel is {KeroseneEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double KeroseneRefill = Convert.ToInt32(Console.ReadLine());
                                double KeroseneLiter = KeroseneRefill / KeroseneMarketPrice;
                                Console.WriteLine($"You can refill {KeroseneLiter} liters of Diesel");
                                break;
                            case 5:
                                double UnleadedMarketPrice = 59.06;
                                double UnleadedEarned = 0;
                                foreach (var UnleadedEarning in UnleadedGasEarned)
                                {
                                    UnleadedEarned += UnleadedEarning;
                                }
                                Console.WriteLine($"Your total earning for Diesel is {UnleadedEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double UnleadedRefill = Convert.ToInt32(Console.ReadLine());
                                double UnleadedLiter = UnleadedRefill / UnleadedMarketPrice;
                                Console.WriteLine($"You can refill {UnleadedLiter} liters of Diesel");
                                break;
                            case 6:
                                double PetrolMarketPrice = 54.06;
                                double PetrolEarned = 0;
                                foreach (var PetrolEarning in PetrolGasEarned)
                                {
                                    PetrolEarned += PetrolEarning;
                                }
                                Console.WriteLine($"Your total earning for Diesel is {PetrolEarned}.");
                                Console.Write("\nHow much Diesel do you want to refill?: ");
                                double PetrolRefill = Convert.ToInt32(Console.ReadLine());
                                double PetrolLiter = PetrolRefill / PetrolMarketPrice;
                                Console.WriteLine($"You can refill {PetrolLiter} liters of Diesel");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Thank you. We're closed.");
                        Stop = 100;
                        break;

                }
            }
        }
    }
}