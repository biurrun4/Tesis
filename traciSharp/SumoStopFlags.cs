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

        public SumoStopFlags(bool paramBoolean1, bool paramBoolean2, bool paramBoolean3, bool paramBoolean4, bool paramBoolean5)
        {
            this.parking = paramBoolean1;
            this.triggered = paramBoolean2;
            this.containerTriggered = paramBoolean3;
            this.isBusStop = paramBoolean4;
            this.isContainerStop = paramBoolean5;
        }

        public SumoStopFlags(byte paramByte)
        {
            byte[] arrayOfByte = { 1, 2, 4, 8, 16, 32 };
            this.stopped = ((paramByte & arrayOfByte[0]) == arrayOfByte[0]);
            this.parking = ((paramByte & arrayOfByte[1]) == arrayOfByte[1]);
            this.triggered = ((paramByte & arrayOfByte[2]) == arrayOfByte[2]);
            this.containerTriggered = ((paramByte & arrayOfByte[3]) == arrayOfByte[3]);
            this.isBusStop = ((paramByte & arrayOfByte[4]) == arrayOfByte[4]);
            this.isContainerStop = ((paramByte & arrayOfByte[5]) == arrayOfByte[5]);
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
