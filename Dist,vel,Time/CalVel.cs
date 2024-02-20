using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dist_vel_Time
{
    public class CalVel
    {
        // Propiedades 
        public double Distance { get; set; }
        public double Time { get; set; }

        // Constructor 
        public CalVel(double distance, double time)
        {
            Distance = distance;
            Time = time;
        }

        // Método 
        public double CalcularVelocidad()
        {
            return Distance / Time;
        }
    }
}
