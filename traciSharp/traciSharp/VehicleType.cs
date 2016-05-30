using container;
using sumo.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traciSharp
{

    public class Vehicletype
    {
        public static SumoCommand getAccel(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(70), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(1), "", Convert.ToInt32(181), Convert.ToInt32(9));
        }

        public static SumoCommand getColor(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(69), typeID, Convert.ToInt32(181), Convert.ToInt32(17));
        }

        public static SumoCommand getDecel(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(71), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getEmissionClass(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(74), typeID, Convert.ToInt32(181), Convert.ToInt32(12));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(0), "", Convert.ToInt32(181), Convert.ToInt32(14));
        }

        public static SumoCommand getImperfection(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(93), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getLength(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(68), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getMaxSpeed(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(65), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getMinGap(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(76), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getShapeClass(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(75), typeID, Convert.ToInt32(181), Convert.ToInt32(12));
        }

        public static SumoCommand getSpeedDeviation(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(95), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedFactor(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(94), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getTau(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(72), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand getVehicleClass(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(73), typeID, Convert.ToInt32(181), Convert.ToInt32(12));
        }

        public static SumoCommand getWidth(String typeID)
        {
            return new SumoCommand(Convert.ToInt32(165), Convert.ToInt32(77), typeID, Convert.ToInt32(181), Convert.ToInt32(11));
        }

        public static SumoCommand setAccel(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(70), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setColor(String typeID, SumoColor color)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(69), typeID, color);
        }

        public static SumoCommand setDecel(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(71), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setEmissionClass(String typeID, String eClass)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(74), typeID, eClass);
        }

        public static SumoCommand setImperfection(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(93), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setLength(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(68), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setMaxSpeed(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(65), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setMinGap(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(76), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setShapeClass(String typeID, String eClass)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(75), typeID, eClass);
        }

        public static SumoCommand setSpeedDeviation(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(95), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setSpeedFactor(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(94), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setTau(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(72), typeID, Convert.ToInt32(value));
        }

        public static SumoCommand setVehicleClass(String typeID, String eClass)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(73), typeID, eClass);
        }

        public static SumoCommand setWidth(String typeID, double value)
        {
            return new SumoCommand(Convert.ToInt32(197), Convert.ToInt32(77), typeID, Convert.ToInt32(value));
        }
    }
}
