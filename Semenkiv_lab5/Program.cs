using System;

namespace Laba5_V_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship1 = new Ship(speed:30,manufacturerBrand:"kia",mamanufacturerCountry:"usa",iSLicense:false,yearRelease:2,maxCountPeople:2,countMotors:4,type:"some_type",isMilitary:true,countDistanceTravel:1111);
            Barge barge1 = new Barge(speed: 30, manufacturerBrand: "aval", mamanufacturerCountry: "uk", iSLicense: true, yearRelease: 290, maxCountPeople: 300, countMotors: 1, maximumCargoWeight: 322.4, maximumCargoSquare: 233.4, isBusy: true);
            Yacht yacht1 = new Yacht(speed: 30, manufacturerBrand: "motors", mamanufacturerCountry: "usa", iSLicense: true, yearRelease: 1990, maxCountPeople: 20, countMotors: 9,countSeils:0,location:"uk",isHaveAnchor:false);

            Watercrafts watercrafts = new Watercrafts(ship1, barge1, barge1);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(watercrafts);
            watercrafts.Add(yacht1);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(watercrafts);
            watercrafts.RemoveByIndex(0);
            watercrafts.RemoveByIndex(0);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(watercrafts);
            watercrafts.UpdateByIndex(yacht1, 0);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(watercrafts);

        }
    }
}
