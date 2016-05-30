using System;
using System.Text;

namespace container
{
    public class SumoStopFlags
    {
        public bool stopped = false;
        public bool parking = false;
        public bool triggered = false;
        public bool containerTriggered = false;
        public bool isBusStop = false;
        public bool isContainerStop = false;

        public SumoStopFlags(bool parking, bool triggered, bool containerTriggered, bool isBusStop, bool isContainerStop)
        {
            this.parking = parking;
            this.triggered = triggered;
            this.containerTriggered = containerTriggered;
            this.isBusStop = isBusStop;
            this.isContainerStop = isContainerStop;
        }

        public SumoStopFlags(byte flags)
        {
            byte[] arrayOfByte = { 1, 2, 4, 8, 16, 32 };
            this.stopped = ((flags & arrayOfByte[0]) == arrayOfByte[0]);
            this.parking = ((flags & arrayOfByte[1]) == arrayOfByte[1]);
            this.triggered = ((flags & arrayOfByte[2]) == arrayOfByte[2]);
            this.containerTriggered = ((flags & arrayOfByte[3]) == arrayOfByte[3]);
            this.isBusStop = ((flags & arrayOfByte[4]) == arrayOfByte[4]);
            this.isContainerStop = ((flags & arrayOfByte[5]) == arrayOfByte[5]);
        }

        public byte getID()
        {
            StringBuilder localStringBuilder = new StringBuilder();
            localStringBuilder.Append(this.isContainerStop ? "1" : "0");
            localStringBuilder.Append(this.isBusStop ? "1" : "0");
            localStringBuilder.Append(this.containerTriggered ? "1" : "0");
            localStringBuilder.Append(this.triggered ? "1" : "0");
            localStringBuilder.Append(this.parking ? "1" : "0");
            return (byte) Convert.ToInt32(localStringBuilder.ToString(), 2);
        }
    }
}
