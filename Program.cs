using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {

            // Create set named ShowRoom
            HashSet<string> ShowRoom = new HashSet<string> ();

            // Add cars to ShowRoom
            ShowRoom.Add("Taurus");
            ShowRoom.Add("Camry");
            ShowRoom.Add("Accord");
            ShowRoom.Add("Focus");

            // Add second instance of Taurus to ShowRoom - No change
            ShowRoom.Add("Taurus");
            
            // Create set named UsedLot
            HashSet<string> UsedLot = new HashSet<string> ();

            // Add cars to UsedLot
            UsedLot.Add("Corolla");
            UsedLot.Add("Mustang");

            // Merge Used Lot into ShowRoom
            ShowRoom.UnionWith(UsedLot);

            // Remove Taurus from ShowRoom
            ShowRoom.Remove("Taurus");

            // Create set named JunkYard
            HashSet<string> JunkYard = new HashSet<string> ();
            
            // Add cars to JunkYard
            JunkYard.Add("Altima");
            JunkYard.Add("Fusion");
            JunkYard.Add("Elantra");
            JunkYard.Add("Taurus");
            JunkYard.Add("Mustang");

            // Create new set named clone with content from ShowRoom
            HashSet<string> clone = new HashSet<string>(ShowRoom);

            // Select only the cars in both the clone set and the JunkYard set
            clone.IntersectWith(JunkYard);

            // Remove Altima from JunkYard
            JunkYard.Remove("Altima");

            // Merge ShowRoom with JunkYard
            ShowRoom.UnionWith(JunkYard);

            // Iterate over vehicles in ShowRoom
            foreach (string vehicle in ShowRoom) {
                // Write vehicles in ShowRoom to console
                Console.WriteLine ($"{vehicle}");
            }
        }
    }
}