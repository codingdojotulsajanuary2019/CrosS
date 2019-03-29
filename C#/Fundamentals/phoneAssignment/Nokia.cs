using System;

namespace phoneAssignment
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return "Beep";
        }
        public string Unlock() 
        {
            return "Click!";
        }
        public override void DisplayInfo() 
        {
            // your code here            
        }
    }
}