//In college campus we want structured parkin plan is required vehicle into these type 
//VIP /faculty --0 fees
//student car charged --10rs 
//visitors car--20 Rs
//the so we want car registration first then enter ,
//automatically collect the total collection and generate a summary report displaying the information the number vehicle park ,
//category, and total revenue collected

using System;
using System.Collections.Generic;

class ParkingSystem
{
    
    enum VehicleCategory { VIP, Faculty, Student, Visitor }

    
    class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public VehicleCategory Category { get; set; }
    }

    
    private static List<Vehicle> parkedVehicles = new List<Vehicle>();
    private static int totalRevenue = 0;
    
   
    private static Dictionary<VehicleCategory, int> parkingFees = new Dictionary<VehicleCategory, int>
    {
        { VehicleCategory.VIP, 0 },
        { VehicleCategory.Faculty, 0 },
        { VehicleCategory.Student, 10 },
        { VehicleCategory.Visitor, 20 }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nCollege Parking System");
            Console.WriteLine("1. Register Vehicle");
            Console.WriteLine("2. Generate Summary Report");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterVehicle();
                    break;
                case "2":
                    GenerateSummaryReport();
                    break;
                case "3":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void RegisterVehicle()
    {
        Console.Write("\nEnter Vehicle Registration Number: ");
        string regNumber = Console.ReadLine();

        Console.WriteLine("Select Category: ");
        Console.WriteLine("1. VIP / Faculty (No Fees)");
        Console.WriteLine("2. Student Car (₹10)");
        Console.WriteLine("3. Visitor Car (₹20)");
        Console.Write("Enter choice: ");
        string categoryChoice = Console.ReadLine();

        VehicleCategory category;
        switch (categoryChoice)
        {
            case "1":
                category = VehicleCategory.VIP;
                break;
            case "2":
                category = VehicleCategory.Student;
                break;
            case "3":
                category = VehicleCategory.Visitor;
                break;
            default:
                Console.WriteLine("Invalid category! Vehicle not registered.");
                return;
        }

        
        Vehicle newVehicle = new Vehicle { RegistrationNumber = regNumber, Category = category };
        parkedVehicles.Add(newVehicle);
        totalRevenue += parkingFees[category];

        Console.WriteLine($"Vehicle {regNumber} registered under {category} category. Fees Collected: ₹{parkingFees[category]}");
    }

    static void GenerateSummaryReport()
    {
        Console.WriteLine("\n--- Parking Summary Report ---");

        int vipCount = 0, studentCount = 0, visitorCount = 0;
        
        foreach (var vehicle in parkedVehicles)
        {
            if (vehicle.Category == VehicleCategory.VIP) vipCount++;
            else if (vehicle.Category == VehicleCategory.Student) studentCount++;
            else if (vehicle.Category == VehicleCategory.Visitor) visitorCount++;
        }

        Console.WriteLine($"Total Vehicles Parked: {parkedVehicles.Count}");
        Console.WriteLine($"VIP / Faculty: {vipCount}");
        Console.WriteLine($"Student Cars: {studentCount}");
        Console.WriteLine($"Visitor Cars: {visitorCount}");
        Console.WriteLine($"Total Revenue Collected: ₹{totalRevenue}");
    }
}
