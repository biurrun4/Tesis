using System.Collections.Generic;

namespace container
{

    public class SumoVehicleSignalState
    {
        public static readonly SumoVehicleSignalState VEH_SIGNAL_BLINKER_RIGHT = new SumoVehicleSignalState(0);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_BLINKER_LEFT = new SumoVehicleSignalState(1);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_BLINKER_EMERGENCY = new SumoVehicleSignalState(2);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_BRAKELIGHT = new SumoVehicleSignalState(3);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_FRONTLIGHT = new SumoVehicleSignalState(4);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_FOGLIGHT = new SumoVehicleSignalState(5);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_HIGHBEAM = new SumoVehicleSignalState(6);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_BACKDRIVE = new SumoVehicleSignalState(7);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_WIPER = new SumoVehicleSignalState(8);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_DOOR_OPEN_LEFT = new SumoVehicleSignalState(9);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_DOOR_OPEN_RIGHT = new SumoVehicleSignalState(10);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_EMERGENCY_BLUE = new SumoVehicleSignalState(11);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_EMERGENCY_RED = new SumoVehicleSignalState(12);
        public static readonly SumoVehicleSignalState VEH_SIGNAL_EMERGENCY_YELLOW = new SumoVehicleSignalState(13);

        public static IEnumerable<SumoVehicleSignalState> Values
        {
            get
            {
                yield return VEH_SIGNAL_BLINKER_RIGHT;
                yield return VEH_SIGNAL_BLINKER_LEFT;
                yield return VEH_SIGNAL_BLINKER_EMERGENCY;
                yield return VEH_SIGNAL_BRAKELIGHT;
                yield return VEH_SIGNAL_FRONTLIGHT;
                yield return VEH_SIGNAL_FOGLIGHT;
                yield return VEH_SIGNAL_HIGHBEAM;
                yield return VEH_SIGNAL_BACKDRIVE;
                yield return VEH_SIGNAL_WIPER;
                yield return VEH_SIGNAL_DOOR_OPEN_LEFT;
                yield return VEH_SIGNAL_DOOR_OPEN_RIGHT;
                yield return VEH_SIGNAL_EMERGENCY_BLUE;
                yield return VEH_SIGNAL_EMERGENCY_RED;
                yield return VEH_SIGNAL_EMERGENCY_YELLOW;
            }
        }

        private readonly int pos;

        private SumoVehicleSignalState(int pos)
        {
            this.pos = pos;
        }

        public int getPos()
        {
            return this.pos;
        }
    }
}
