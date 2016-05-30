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

        public Command(Storage rawStorage)
        {
            int i = rawStorage.readUnsignedByte();
            if (i == 0)
            {
                i = rawStorage.readInt() - HEADER_SIZE;
            }
            else {
                i -= 2;
            }
            this.id = rawStorage.readUnsignedByte();
            short[] arrayOfShort = new short[i];
            for (int j = 0; j < i; j++)
            {
                arrayOfShort[j] = ((short)(byte)rawStorage.readUnsignedByte());
            }
            this.content = new Storage(arrayOfShort);
        }

        public Command(int commandId)
        {
            if (commandId > 255)
            {
                throw new ArgumentException("id should fit in a byte");
            }
            this.content = new Storage();
            this.id = commandId;
        }

        public int Id()
        {
            return this.id;
        }

        public Storage Content()
        {
            return this.content;
        }

        public void writeRawTo(Storage rawStorage)
        {
            rawStorage.writeByte(0);
            rawStorage.writeInt(HEADER_SIZE + this.content.size());
            rawStorage.writeUnsignedByte(this.id);
            IEnumerator<Byte> localIterator = this.content.getStorageList().GetEnumerator();
            List<Byte> storagelist = this.content.getStorageList();
            while (localIterator.MoveNext())
            {
                Byte localByte = (Byte)localIterator.Current;
                rawStorage.writeByte((short)Convert.ToByte(localByte));
            }
        }

        public int rawSize()
        {
            return HEADER_SIZE + this.content.size();
        }
    }
}