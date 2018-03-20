using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordConvertersBLL;

namespace CoordConvertersBLL
{ 
    public class DMSConverter
    {
        public double Dms2Dd(DMSCoord dmsCoord)
        {
            
                double errValue = 9999.0;
                Boolean positive = false;


                /** perform initial degree range checks: 
                 *  180 degree and 60 seconds/minute requirements */
                if (dmsCoord.deg < 0 || dmsCoord.deg > 180) return errValue;
                if (dmsCoord.min < 0 || dmsCoord.min >= 60) return errValue;
                if (dmsCoord.sec < 0 || dmsCoord.sec >= 60) return errValue;

            /** make decisions of bearings according to angles,
                        *  and check for 90 degree requirements */
            switch (dmsCoord.quadrant)
            {
                case Quadrant.N:
               
                    if (dmsCoord.deg > 90) return errValue;
                    positive = true;
                    break;
               
                case Quadrant.E:
                    positive = true;
                    break;
               
                case Quadrant.S:
                    if (dmsCoord.deg > 90) return errValue;
                    positive = false;
                    break;
                
                case Quadrant.W:
                    positive = false;
                    break;
                default:
                    return errValue;
            }

            double seconds = dmsCoord.sec / 60;
                double minutes = (dmsCoord.min + seconds) / 60;

                double dd = dmsCoord.deg + ((dmsCoord.min + (dmsCoord.sec / 60)) / 60); // perform the conversion calculation
                return (positive ? dd : (-1 * dd)); // return the decimal degrees
        }

        
            

          
        
}
}
