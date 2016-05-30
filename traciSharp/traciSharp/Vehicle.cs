using container;
using sumo.util;
using System;

namespace sumo.cmd
{

    public class Vehicle
    {
        public static SumoCommand getAccel(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(70), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getIDCount()
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(1), "", Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getAdaptedTraveltime(String vehID, int time, String edgeID)
        {
            Object[] arrayOfObject = { Convert.ToInt32(time), edgeID };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(88), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getAngle(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(67), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getAllowedSpeed(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(183), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLeader(String vehID, double dist)
        {
            Object[] arrayOfObject = { Convert.ToDouble(dist) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(104), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(15));
        }

        public static SumoCommand getPersonNumber(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(103), vehID, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getBestLanes(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(178), vehID, Convert.ToInt32(180), Convert.ToInt32(15));
        }

        public static SumoCommand getCO2Emission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(96), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getCOEmission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(97), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getColor(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(69), vehID, Convert.ToInt32(180), Convert.ToInt32(17));
        }

        public static SumoCommand getDecel(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(71), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDrivingDistance(String vehID, String edgeID, double pos, byte laneNum)
        {
            Object[] arrayOfObject = { edgeID, Convert.ToDouble(pos), Convert.ToByte(laneNum) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(131), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDrivingDistance2D(String vehID, double x, double y)
        {
            Object[] arrayOfObject = { Convert.ToDouble(x), Convert.ToDouble(y) };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(131), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getDistance(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(132), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getEffort(String vehID, int time, String edgeID)
        {
            Object[] arrayOfObject = { Convert.ToInt32(time), edgeID };
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(89), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getEmissionClass(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(74), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getFuelConsumption(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(101), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getHCEmission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(98), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getIDList()
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(0), "", Convert.ToInt32(180), Convert.ToInt32(14));
        }

        public static SumoCommand getImperfection(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(93), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLaneID(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(81), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getLaneIndex(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(82), vehID, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getLanePosition(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(86), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getLength(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(68), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getMaxSpeed(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(65), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getMinGap(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(76), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getNOxEmission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(100), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getNoiseEmission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(102), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getPMxEmission(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(99), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getPosition(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(66), vehID, Convert.ToInt32(180), Convert.ToInt32(1));
        }

        public static SumoCommand getPosition3D(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(57), vehID, Convert.ToInt32(180), Convert.ToInt32(3));
        }

        public static SumoCommand getRoadID(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(80), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getRoute(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(84), vehID, Convert.ToInt32(180), Convert.ToInt32(14));
        }

        public static SumoCommand getRouteID(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(83), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getRouteIndex(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(105), vehID, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getShapeClass(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(75), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getSignals(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(91), vehID, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand getSpeed(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(64), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedDeviation(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(95), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedFactor(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(94), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getSpeedWithoutTraCI(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(177), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getStopState(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7));
        }

        public static SumoCommand getTau(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(72), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getWaitingTime(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(122), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand getTypeID(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(79), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getVehicleClass(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(73), vehID, Convert.ToInt32(180), Convert.ToInt32(12));
        }

        public static SumoCommand getWidth(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(77), vehID, Convert.ToInt32(180), Convert.ToInt32(11));
        }

        public static SumoCommand isStopped(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7), "isStopped");
        }

        public static SumoCommand isStoppedTriggered(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7), "isStoppedTriggered");
        }

        public static SumoCommand isAtContainerStop(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7), "isAtContainerStop");
        }

        public static SumoCommand isStoppedParking(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7), "isStoppedParking");
        }

        public static SumoCommand isAtBusStop(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(181), vehID, Convert.ToInt32(180), Convert.ToInt32(7), "isAtBusStop");
        }

        public static SumoCommand isRouteValid(String vehID)
        {
            return new SumoCommand(Convert.ToInt32(164), Convert.ToInt32(146), vehID, Convert.ToInt32(180), Convert.ToInt32(7));
        }

        public static SumoCommand slowDown(String vehID, double speed, int duration)
        {
            Object[] arrayOfObject = { Convert.ToDouble(speed), Convert.ToInt32(duration) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(20), vehID, arrayOfObject, Convert.ToInt32(180), Convert.ToInt32(9));
        }

        public static SumoCommand add(String vehID, String typeID, String routeID, int departTime, double pos, double speed, byte laneNum)
        {
            Object[] arrayOfObject = { typeID, routeID, Convert.ToInt32(departTime), Convert.ToDouble(pos), Convert.ToDouble(speed), Convert.ToByte(laneNum) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(128), vehID, arrayOfObject);
        }

        public static SumoCommand changeLane(String vehID, byte laneIndex, int duration)
        {
            Object[] arrayOfObject = { Convert.ToByte(laneIndex), Convert.ToInt32(duration) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(19), vehID, arrayOfObject);
        }

        public static SumoCommand changeTarget(String vehID, String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(49), vehID, edgeID);
        }

        public static SumoCommand moveTo(String vehID, String edgeID, double pos)
        {
            Object[] arrayOfObject = { edgeID, Convert.ToDouble(pos) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(92), vehID, arrayOfObject);
        }

        public static SumoCommand moveToVTD(String vehID, String edgeID, int lane, double x, double y)
        {
            Object[] arrayOfObject = { edgeID, Convert.ToInt32(lane), Convert.ToDouble(x), Convert.ToDouble(y) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(180), vehID, arrayOfObject);
        }

        public static SumoCommand remove(String vehID, byte reason)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(129), vehID, Convert.ToByte(reason));
        }

        public static SumoCommand rerouteEffort(String vehID)
        {
            Object[] arrayOfObject = { vehID };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(145), vehID, arrayOfObject);
        }

        public static SumoCommand rerouteTraveltime(String vehID)
        {
            Object[] arrayOfObject = { vehID };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(144), vehID, arrayOfObject);
        }

        public static SumoCommand setAccel(String vehID, double accel)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(70), vehID, Convert.ToDouble(accel));
        }

        public static SumoCommand setAdaptedTraveltime(String vehID, int begTime, int endTime, String edgeID, double time)
        {
            Object[] arrayOfObject = { Convert.ToInt32(begTime), Convert.ToInt32(endTime), edgeID, Convert.ToDouble(time) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(88), vehID, arrayOfObject);
        }

        public static SumoCommand setColor(String vehID, SumoColor color)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(69), vehID, color);
        }

        public static SumoCommand setDecel(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(71), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setLaneChangeMode(String vehID, int mode)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(182), vehID, Convert.ToInt32(mode));
        }

        public static SumoCommand setRoute(String vehID, SumoStringList edgeList)
        {
            Object[] arrayOfObject = { edgeList };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(87), vehID, arrayOfObject);
        }

        public static SumoCommand setType(String vehID, String typeID)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(79), vehID, typeID);
        }

        public static SumoCommand setEffort(String vehID, int begTime, int endTime, String edgeID, double effort)
        {
            Object[] arrayOfObject = { Convert.ToInt32(begTime), Convert.ToInt32(endTime), edgeID, Convert.ToDouble(effort) };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(89), vehID, arrayOfObject);
        }

        public static SumoCommand setEmissionClass(String vehID, String emClass)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(74), vehID, emClass);
        }

        public static SumoCommand setImperfection(String vehID, double imperfection)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(93), vehID, Convert.ToDouble(imperfection));
        }

        public static SumoCommand setLength(String vehID, double length)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(68), vehID, Convert.ToDouble(length));
        }

        public static SumoCommand setMaxSpeed(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(65), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setMinGap(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(76), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setRouteID(String vehID, String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(83), vehID, edgeID);
        }

        public static SumoCommand setShapeClass(String vehID, String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(75), vehID, edgeID);
        }

        public static SumoCommand setSignals(String vehID, String edgeID)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(91), vehID, edgeID);
        }

        public static SumoCommand setSpeed(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(64), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setSpeedDeviation(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(95), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setSpeedFactor(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(94), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setSpeedMode(String vehID, int mode)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(179), vehID, Convert.ToInt32(mode));
        }

        public static SumoCommand setStop(String vehID, String edgeID, double pos, byte laneIndex, int duration, SumoStopFlags flags)
        {
            Object[] arrayOfObject = { edgeID, Convert.ToDouble(pos), Convert.ToByte(laneIndex), Convert.ToInt32(duration), flags };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(18), vehID, arrayOfObject);
        }

        public static SumoCommand setBusStop(String vehID, String edgeID, int paramInt1, int paramInt2)
        {
            SumoStopFlags localSumoStopFlags = new SumoStopFlags(false, false, false, true, false);
            return setStop(vehID, edgeID, 1.0D, (byte)0, paramInt1, localSumoStopFlags);
        }

        public static SumoCommand setContainerStop(String vehID, String edgeID, int paramInt1, int paramInt2)
        {
            SumoStopFlags localSumoStopFlags = new SumoStopFlags(false, false, false, false, true);
            return setStop(vehID, edgeID, 1.0D, (byte)0, paramInt1, localSumoStopFlags);
        }

        public static SumoCommand resume(String vehID)
        {
            Object[] arrayOfObject = { vehID };
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(25), vehID, arrayOfObject);
        }

        public static SumoCommand setTau(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(72), vehID, Convert.ToDouble(value));
        }

        public static SumoCommand setVehicleClass(String vehID, String vClass)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(73), vehID, vClass);
        }

        public static SumoCommand setWidth(String vehID, double value)
        {
            return new SumoCommand(Convert.ToInt32(196), Convert.ToInt32(77), vehID, Convert.ToDouble(value));
        }
    }

}
