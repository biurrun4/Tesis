using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Vehicle
    {
        public static SumoCommand getAccel(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(70), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(1), "", Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getAdaptedTraveltime(String paramString1, int paramInt, String paramString2)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt), paramString2 };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(88), paramString1, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getAngle(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(67), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getAllowedSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(183), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLeader(String paramString, double paramDouble)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(104), paramString, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(15));
        }

        public static SumoCommand getPersonNumber(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(103), paramString, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getBestLanes(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(178), paramString, Convert.ToInt32(180), Convert.ToInt32(15));
        }

        public static SumoCommand getCO2Emission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(96), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(97), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getColor(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(69), paramString, Convert.ToInt32(180), Convert.ToInt32(17));
        }

        public static SumoCommand getDecel(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(71), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDrivingDistance(String paramString1, String paramString2, double paramDouble, byte paramByte)
        {
            Object[] arrayOfObject = { paramString2, Convert.ToDouble(paramDouble), Convert.ToByte(paramByte) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(131), paramString1, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDrivingDistance2D(String paramString, double paramDouble1, double paramDouble2)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(131), paramString, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDistance(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(132), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getEffort(String paramString1, int paramInt, String paramString2)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt), paramString2 };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(89), paramString1, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getEmissionClass(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(74), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getFuelConsumption(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(101), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(98), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(0), "", Convert.ToInt32(180), Convert.ToInt32(14));
        }

        public static SumoCommand getImperfection(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(93), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLaneID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(81), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getLaneIndex(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(82), paramString, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getLanePosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(86), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLength(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(68), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getMaxSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(65), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getMinGap(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(76), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getNOxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(100), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(102), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(99), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getPosition(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(66), paramString, Convert.ToInt32(180), Convert.ToInt32(1));
        }

        public static SumoCommand getPosition3D(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(57), paramString, Convert.ToInt32(180), Convert.ToInt32(3));
        }

        public static SumoCommand getRoadID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(80), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getRoute(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(84), paramString, Convert.ToInt32(180), Convert.ToInt32(14));
        }

        public static SumoCommand getRouteID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(83), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getRouteIndex(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(105), paramString, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getShapeClass(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(75), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getSignals(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(91), paramString, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getSpeed(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(64), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedDeviation(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(95), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedFactor(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(94), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedWithoutTraCI(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(177), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getStopState(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7));
        }

        public static SumoCommand getTau(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(72), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(122), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getTypeID(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(79), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getVehicleClass(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(73), paramString, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getWidth(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(77), paramString, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand isStopped(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7), "isStopped");
        }

        public static SumoCommand isStoppedTriggered(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7), "isStoppedTriggered");
        }

        public static SumoCommand isAtContainerStop(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7), "isAtContainerStop");
        }

        public static SumoCommand isStoppedParking(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7), "isStoppedParking");
        }

        public static SumoCommand isAtBusStop(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), paramString, Convert.ToInt32(180), Convert.ToInt32(7), "isAtBusStop");
        }

        public static SumoCommand isRouteValid(String paramString)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(146), paramString, Convert.ToInt32(180), Convert.ToInt32(7));
        }

        public static SumoCommand slowDown(String paramString, double paramDouble, int paramInt)
        {
            Object[] arrayOfObject = { Convert.ToDouble(paramDouble), Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(20), paramString, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand add(String paramString1, String paramString2, String paramString3, int paramInt, double paramDouble1, double paramDouble2, byte paramByte)
        {
            Object[] arrayOfObject = { paramString2, paramString3, Convert.ToInt32(paramInt), Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2), Convert.ToByte(paramByte) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(128), paramString1, arrayOfObject);
        }

        public static SumoCommand changeLane(String paramString, byte paramByte, int paramInt)
        {
            Object[] arrayOfObject = { Convert.ToByte(paramByte), Convert.ToInt32(paramInt) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(19), paramString, arrayOfObject);
        }

        public static SumoCommand changeTarget(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(49), paramString1, paramString2);
        }

        public static SumoCommand moveTo(String paramString1, String paramString2, double paramDouble)
        {
            Object[] arrayOfObject = { paramString2, Convert.ToDouble(paramDouble) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(92), paramString1, arrayOfObject);
        }

        public static SumoCommand moveToVTD(String paramString1, String paramString2, int paramInt, double paramDouble1, double paramDouble2)
        {
            Object[] arrayOfObject = { paramString2, Convert.ToInt32(paramInt), Convert.ToDouble(paramDouble1), Convert.ToDouble(paramDouble2) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(180), paramString1, arrayOfObject);
        }

        public static SumoCommand remove(String paramString, byte paramByte)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(129), paramString, Convert.ToByte(paramByte));
        }

        public static SumoCommand rerouteEffort(String paramString)
        {
            Object[] arrayOfObject = { paramString };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(145), paramString, arrayOfObject);
        }

        public static SumoCommand rerouteTraveltime(String paramString)
        {
            Object[] arrayOfObject = { paramString };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(144), paramString, arrayOfObject);
        }

        public static SumoCommand setAccel(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(70), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setAdaptedTraveltime(String paramString1, int paramInt1, int paramInt2, String paramString2, double paramDouble)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt1), Convert.ToInt32(paramInt2), paramString2, Convert.ToDouble(paramDouble) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(88), paramString1, arrayOfObject);
        }

        public static SumoCommand setColor(String paramString, SumoColor paramSumoColor)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(69), paramString, paramSumoColor);
        }

        public static SumoCommand setDecel(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(71), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setLaneChangeMode(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(182), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setRoute(String paramString, SumoStringList paramSumoStringList)
        {
            Object[] arrayOfObject = { paramSumoStringList };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(87), paramString, arrayOfObject);
        }

        public static SumoCommand setType(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(79), paramString1, paramString2);
        }

        public static SumoCommand setEffort(String paramString1, int paramInt1, int paramInt2, String paramString2, double paramDouble)
        {
            Object[] arrayOfObject = { Convert.ToInt32(paramInt1), Convert.ToInt32(paramInt2), paramString2, Convert.ToDouble(paramDouble) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(89), paramString1, arrayOfObject);
        }

        public static SumoCommand setEmissionClass(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(74), paramString1, paramString2);
        }

        public static SumoCommand setImperfection(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(93), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setLength(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(68), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMaxSpeed(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(65), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setMinGap(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(76), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setRouteID(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(83), paramString1, paramString2);
        }

        public static SumoCommand setShapeClass(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(75), paramString1, paramString2);
        }

        public static SumoCommand setSignals(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(91), paramString1, paramString2);
        }

        public static SumoCommand setSpeed(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(64), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setSpeedDeviation(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(95), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setSpeedFactor(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(94), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setSpeedMode(String paramString, int paramInt)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(179), paramString, Convert.ToInt32(paramInt));
        }

        public static SumoCommand setStop(String paramString1, String paramString2, double paramDouble, byte paramByte, int paramInt, SumoStopFlags paramSumoStopFlags)
        {
            Object[] arrayOfObject = { paramString2, Convert.ToDouble(paramDouble), Convert.ToByte(paramByte), Convert.ToInt32(paramInt), paramSumoStopFlags };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(18), paramString1, arrayOfObject);
        }

        public static SumoCommand setBusStop(String paramString1, String paramString2, int paramInt1, int paramInt2)
        {
            SumoStopFlags localSumoStopFlags = new SumoStopFlags(false, false, false, true, false);
            return setStop(paramString1, paramString2, 1.0D, (byte)0, paramInt1, localSumoStopFlags);
        }

        public static SumoCommand setContainerStop(String paramString1, String paramString2, int paramInt1, int paramInt2)
        {
            SumoStopFlags localSumoStopFlags = new SumoStopFlags(false, false, false, false, true);
            return setStop(paramString1, paramString2, 1.0D, (byte)0, paramInt1, localSumoStopFlags);
        }

        public static SumoCommand resume(String paramString)
        {
            Object[] arrayOfObject = { paramString };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(25), paramString, arrayOfObject);
        }

        public static SumoCommand setTau(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(72), paramString, Convert.ToDouble(paramDouble));
        }

        public static SumoCommand setVehicleClass(String paramString1, String paramString2)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(73), paramString1, paramString2);
        }

        public static SumoCommand setWidth(String paramString, double paramDouble)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(77), paramString, Convert.ToDouble(paramDouble));
        }
    }

}
