using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.util;

namespace traciSharp
{

    [Serializable]
    public class Storage
    {
        private const long serialVersionUID = 1L;
        private List<Byte> storageList;
        private int position;
        private ListIterator<Byte> listIt;

        public Storage()
        {
            this.storageList = new List<Byte>();
            init();
        }

        public Storage(byte[] packet)
        {
            if (packet == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            this.storageList = new List<Byte>();
            for (int i = 0; i < packet.Length; i++)
            {
                writeByte((short)packet[i]);
            }
            init();
        }

        public Storage(byte[] packet, int offset, int length)
        {
            if (packet == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            if (length > packet.Length)
            {
                throw new IndexOutOfRangeException("length exceeds packet length");
            }
            if (offset + length > packet.Length)
            {
                throw new IndexOutOfRangeException("content is outside the array");
            }
            this.storageList = new List<Byte>();
            for (int i = offset; i < length; i++)
            {
                writeByte((short)packet[i]);
            }
            init();
        }

        public Storage(short[] packet)
        {
            if (packet == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            this.storageList = new List<Byte>();
            for (int i = 0; i < packet.Length; i++)
            {
                writeByte((short)packet[i]);
            }
            init();
        }

        public Storage(short[] packet, int offset, int length)
        {
            if (packet == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            if (length > packet.Length)
            {
                throw new IndexOutOfRangeException("length exceeds packet length");
            }
            if (offset + length > packet.Length)
            {
                throw new IndexOutOfRangeException("content is outside the array");
            }
            this.storageList = new List<byte>();
            for (int i = offset; i < length; i++)
            {
                writeByte(packet[i]);
            }
            init();
        }

        public bool validPos()
        {
            return (this.position < this.storageList.Count) && (this.position >= 0) && (this.storageList.Count != 0);
        }

        public int Position()
        {
            return this.position;
        }

        public void writeByte(short value)

        {
            writeByte(Convert.ToInt32(value));
            Console.WriteLine("Storage.writeByte "+value);
        }

        public void writeByte(int value)

        {
            if ((value < -128) || (value > 127))
            {
                throw new ArgumentException("Error writing byte: byte value may only range from -128 to 127.");
            }
            this.storageList.Add((byte)value);
        }

        public short readByte()

        {
            if (!validPos())
            {
                throw new InvalidOperationException("Error reading byte, invalid list position specified for reading: " + this.position);
            }
            this.position += 1;
            return (short)((Byte)this.listIt.Next());
        }

        public void writeUnsignedByte(short value)

        {
            writeUnsignedByte(value);
        }

        public void writeUnsignedByte(int value)

        {
            if ((value < 0) || (value > 255))
            {
                throw new ArgumentException("Error writing unsigned byte: byte value may only range from 0 to 255.");
            }
            if (value > 127)
            {
                this.storageList.Add((byte)(value - 256));
            }
            else {
                this.storageList.Add((byte)value);
            }
        }

        public short readUnsignedByte()

        {
            if (!validPos())
            {
                throw new InvalidOperationException("Error reading unsigned byte, invalid list position specified for reading: " + this.position);
            }
            this.position += 1;
            return (short)((((Byte)this.listIt.Next()) + 256) % 256);
        }

        public void writeShort(int value)

        {
            MemoryStream localMemoryStream = new MemoryStream(2);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[2];
            if ((value < 32768) || (value > 32768))
            {
                throw new ArgumentException("Error writing short: short value may only range from -32768 to 32768.");
            }
            try
            {
                localBinaryWriter.Write(value);
                localBinaryWriter.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            arrayOfByte = localMemoryStream.ToArray();
            for (int i = 1; i >= 0; i--)
            {
                writeByte((short)arrayOfByte[i]);
            }
        }

        public int readShort()

        {
            byte[] arrayOfByte = new byte[2];
            int i = 0;
            for (int j = 0; j < 2; j++)
            {
                arrayOfByte[j] = ((byte)readByte());
            }
            MemoryStream localMemoryStream = new MemoryStream(arrayOfByte); 
            BinaryReader localBinaryReader = new BinaryReader(localMemoryStream);
            try
            {
                i = localBinaryReader.ReadInt16();
                localBinaryReader.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            return i;
        }

        public void writeInt(int value)

        {
            MemoryStream localMemoryStream = new MemoryStream(4);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[4];
            try
            {
                localBinaryWriter.Write(value);
                localBinaryWriter.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            arrayOfByte = localMemoryStream.ToArray();
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine("Storage.WriteInt: "+i+"-byte: "+ (short)arrayOfByte[i]);
                writeByte((short)arrayOfByte[i]);
            }
        }

        public int readInt()

        {
            byte[] arrayOfByte = new byte[4];
            int i = 0;
            for (int j = 0; j < 4; j++)
            {
                arrayOfByte[j] = ((byte)readByte());
            }
            MemoryStream localMemoryStream = new MemoryStream(arrayOfByte);
            BinaryReader localBinaryReader = new BinaryReader(localMemoryStream);
            try
            {
                i = localBinaryReader.ReadInt32();
                localBinaryReader.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            return i;
        }

        public void writeFloat(float value)

        {
            MemoryStream localMemoryStream = new MemoryStream(4);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[4];
            try
            {
                localBinaryWriter.Write(value);
                localBinaryWriter.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            arrayOfByte = localMemoryStream.ToArray();
            for (int i = 3; i >=0; i--)
            {
                writeByte((short)arrayOfByte[i]);
            }
        }

        public float readFloat()

        {
            byte[] arrayOfByte = new byte[4];
            float f = 0.0F;
            for (int i = 0; i < 4; i++)
            {
                arrayOfByte[i] = ((byte)readByte());
            }
            MemoryStream localMemoryStream = new MemoryStream(arrayOfByte);
            BinaryReader localBinaryReader = new BinaryReader(localMemoryStream);
            try
            {
                f = localBinaryReader.ReadSingle();
                localBinaryReader.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            return f;
        }

        public void writeDouble(double value)

        {
            MemoryStream localMemoryStream = new MemoryStream(8);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[8];
            try
            {
                localBinaryWriter.Write(value);
                localBinaryWriter.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            arrayOfByte = localMemoryStream.ToArray();
            for (int i = 7; i >= 0; i--)
            {
                writeByte((short)arrayOfByte[i]);
            }
        }

        public double readDouble()

        {
            byte[] arrayOfByte = new byte[8];
            double d = 0.0D;
            for (int i = 0; i < 8; i++)
            {
                arrayOfByte[i] = ((byte)readByte());
            }
            MemoryStream localMemoryStream = new MemoryStream(arrayOfByte);
            BinaryReader localBinaryReader = new BinaryReader(localMemoryStream);
            try
            {
                d = localBinaryReader.ReadDouble();
                localBinaryReader.Close();
            }
            catch (IOException e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            return d;
        }

        public void writeStringUTF8(String value)

        {
            writeString(value, "UTF-8");
        }

        public void writeStringASCII(String value)

        {
            writeString(value, "US-ASCII");
        }

        public void writeStringISOLATIN1(String value)

        {
            writeString(value, "ISO-8859-1");
        }

        public void writeStringUTF16BE(String value)

        {
            writeString(value, "UTF-16BE");
        }

        public void writeStringUTF16LE(String value)

        {
            writeString(value, "UTF-16LE");
        }

        private void writeString(String value, String encod)

        {
            byte[] arrayOfByte;
            try
            {
                Encoding enc = Encoding.GetEncoding(encod);
                arrayOfByte = enc.GetBytes(value);
            }
            catch (Exception e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
                return;
            }
            writeInt(value.Length);
            for (int i = 0; i < arrayOfByte.Length; i++)
            {
                writeByte((short)arrayOfByte[i]);
            }
        }

        public String readStringUTF8()

        {
            return readString("UTF-8");
        }

        public String readStringASCII()

        {
            return readString("US-ASCII");
        }

        public String readStringISOLATIN1()

        {
            return readString("ISO-8859-1");
        }

        public String readStringUTF16BE()

        {
            return readString("UTF-16BE");
        }

        public String readStringUTF16LE()

        {
            return readString("UTF-16LE");
        }

        private String readString(String value)

        {
            String str = "";
            int length = readInt();
            byte[] arrayOfByte = new byte[length];
            for (int j = 0; j < length; j++)
            {
                arrayOfByte[j] = ((byte)readByte());
            }
            try
            {
                str = Encoding.GetEncoding(value).GetString(arrayOfByte);
            }
            catch (Exception e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
            }
            return str;
        }

        public void reset()
        {
            this.storageList.Clear();
            init();
        }

        public int size()
        {
            return this.storageList.Count;
        }

        public List<Byte> getStorageList()
        {
            return storageList;
        }

        private void init()
        {
            this.position = 0;
            this.listIt = new ListIterator<byte>(storageList);
        }

        public String toString()
        {
            StringBuilder localStringBuilder = new StringBuilder();
            for (int i = 0; i < this.storageList.Count; i++)
            {
                if (i == this.position)
                {
                    localStringBuilder.Append("[");
                }
                else {
                    localStringBuilder.Append(" ");
                }
                localStringBuilder.Append(String.Format("{0:X}", storageList[i]));
            }
            return localStringBuilder.ToString();
        }
    }
}
