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

        public Storage(byte[] paramArrayOfByte)
        {
            if (paramArrayOfByte == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            this.storageList = new List<Byte>();
            for (int i = 0; i < paramArrayOfByte.Length; i++)
            {
                writeByte((short)paramArrayOfByte[i]);
            }
            init();
        }

        public Storage(byte[] paramArrayOfByte, int paramInt1, int paramInt2)
        {
            if (paramArrayOfByte == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            if (paramInt2 > paramArrayOfByte.Length)
            {
                throw new IndexOutOfRangeException("length exceeds packet length");
            }
            if (paramInt1 + paramInt2 > paramArrayOfByte.Length)
            {
                throw new IndexOutOfRangeException("content is outside the array");
            }
            this.storageList = new List<Byte>();
            for (int i = paramInt1; i < paramInt2; i++)
            {
                writeByte((short)paramArrayOfByte[i]);
            }
            init();
        }

        public Storage(short[] paramArrayOfShort)
        {
            if (paramArrayOfShort == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            this.storageList = new List<Byte>();
            for (int i = 0; i < paramArrayOfShort.Length; i++)
            {
                writeByte((short)paramArrayOfShort[i]);
            }
            init();
        }

        public Storage(short[] paramArrayOfShort, int paramInt1, int paramInt2)
        {
            if (paramArrayOfShort == null)
            {
                throw new NullReferenceException("packet can't be null");
            }
            if (paramInt2 > paramArrayOfShort.Length)
            {
                throw new IndexOutOfRangeException("length exceeds packet length");
            }
            if (paramInt1 + paramInt2 > paramArrayOfShort.Length)
            {
                throw new IndexOutOfRangeException("content is outside the array");
            }
            this.storageList = new List<byte>();
            for (int i = paramInt1; i < paramInt2; i++)
            {
                writeByte(paramArrayOfShort[i]);
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

        public void writeByte(short paramShort)

        {
            writeByte(Convert.ToInt32(paramShort));
            Console.WriteLine("Storage.writeByte "+paramShort);
        }

        public void writeByte(int paramInt)

        {
            if ((paramInt < -128) || (paramInt > 127))
            {
                throw new ArgumentException("Error writing byte: byte value may only range from -128 to 127.");
            }
            this.storageList.Add((byte)paramInt);
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

        public void writeUnsignedByte(short paramShort)

        {
            writeUnsignedByte(paramShort);
        }

        public void writeUnsignedByte(int paramInt)

        {
            if ((paramInt < 0) || (paramInt > 255))
            {
                throw new ArgumentException("Error writing unsigned byte: byte value may only range from 0 to 255.");
            }
            if (paramInt > 127)
            {
                this.storageList.Add((byte)(paramInt - 256));
            }
            else {
                this.storageList.Add((byte)paramInt);
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

        public void writeShort(int paramInt)

        {
            MemoryStream localMemoryStream = new MemoryStream(2);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[2];
            if ((paramInt < 32768) || (paramInt > 32768))
            {
                throw new ArgumentException("Error writing short: short value may only range from -32768 to 32768.");
            }
            try
            {
                localBinaryWriter.Write(paramInt);
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

        public void writeInt(int paramInt)

        {
            MemoryStream localMemoryStream = new MemoryStream(4);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[4];
            try
            {
                localBinaryWriter.Write(paramInt);
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

        public void writeFloat(float paramFloat)

        {
            MemoryStream localMemoryStream = new MemoryStream(4);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[4];
            try
            {
                localBinaryWriter.Write(paramFloat);
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

        public void writeDouble(double paramDouble)

        {
            MemoryStream localMemoryStream = new MemoryStream(8);
            BinaryWriter localBinaryWriter = new BinaryWriter(localMemoryStream);
            byte[] arrayOfByte = new byte[8];
            try
            {
                localBinaryWriter.Write(paramDouble);
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

        public void writeStringUTF8(String paramString)

        {
            writeString(paramString, "UTF-8");
        }

        public void writeStringASCII(String paramString)

        {
            writeString(paramString, "US-ASCII");
        }

        public void writeStringISOLATIN1(String paramString)

        {
            writeString(paramString, "ISO-8859-1");
        }

        public void writeStringUTF16BE(String paramString)

        {
            writeString(paramString, "UTF-16BE");
        }

        public void writeStringUTF16LE(String paramString)

        {
            writeString(paramString, "UTF-16LE");
        }

        private void writeString(String paramString1, String paramString2)

        {
            byte[] arrayOfByte;
            try
            {
                Encoding enc = Encoding.GetEncoding(paramString2);
                arrayOfByte = enc.GetBytes(paramString1);
            }
            catch (Exception e)
            {
                //UnityEngine.Debug.Log(e.StackTrace);
                return;
            }
            writeInt(paramString1.Length);
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

        private String readString(String paramString)

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
                str = Encoding.GetEncoding(paramString).GetString(arrayOfByte);
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
