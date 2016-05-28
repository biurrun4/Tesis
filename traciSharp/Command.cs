using System;
using System.Collections.Generic;
using traciSharp;

namespace traci.protocol
{
    public class Command
    {
        private static int HEADER_SIZE = 6;
        private readonly int id;
        private readonly Storage content;

        public Command(Storage paramStorage)
        {
            int i = paramStorage.readUnsignedByte();
            if (i == 0)
            {
                i = paramStorage.readInt() - HEADER_SIZE;
            }
            else {
                i -= 2;
            }
            this.id = paramStorage.readUnsignedByte();
            short[] arrayOfShort = new short[i];
            for (int j = 0; j < i; j++)
            {
                arrayOfShort[j] = ((short)(byte)paramStorage.readUnsignedByte());
            }
            this.content = new Storage(arrayOfShort);
        }

        public Command(int paramInt)
        {
            if (paramInt > 255)
            {
                throw new ArgumentException("id should fit in a byte");
            }
            this.content = new Storage();
            this.id = paramInt;
        }

        public int Id()
        {
            return this.id;
        }

        public Storage Content()
        {
            return this.content;
        }

        public void writeRawTo(Storage paramStorage)
        {
            paramStorage.writeByte(0);
            paramStorage.writeInt(HEADER_SIZE + this.content.size());
            paramStorage.writeUnsignedByte(this.id);
            IEnumerator<Byte> localIterator = this.content.getStorageList().GetEnumerator();
            List<Byte> storagelist = this.content.getStorageList();
            while (localIterator.MoveNext())
            {
                Byte localByte = (Byte)localIterator.Current;
                paramStorage.writeByte((short)Convert.ToByte(localByte));
            }
        }

        public int rawSize()
        {
            return HEADER_SIZE + this.content.size();
        }
    }
}