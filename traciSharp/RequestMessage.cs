using System;
using System.Collections.Generic;
using System.IO;
using traci.protocol;

namespace traciSharp
{
    public class RequestMessage
    {
        private readonly List<Command> commands = new List<Command>();

        public void append(Command paramCommand)
        {
            if (paramCommand == null)
            {
                throw new NullReferenceException("the command can't be null");
            }
            this.commands.Add(paramCommand);
        }

        public void writeTo(BinaryWriter paramDataOutputStream)

        {
            int length = 4;
            IEnumerator<Command> localIterator = this.commands.GetEnumerator();
            Object localObject;
            while (localIterator.MoveNext())
            {
                localObject = (Command)localIterator.Current;
                length += ((Command)localObject).rawSize();
                Console.WriteLine("RequesMessage.Length partial " + length);
            }
            paramDataOutputStream.Write(length);
            localIterator = this.commands.GetEnumerator();
            Console.WriteLine("RequestMessage.Length final: " + length);
            while (localIterator.MoveNext())
            {
                Command cmd = localIterator.Current;
                Storage localStorage = new Storage();
                cmd.writeRawTo(localStorage);
                Console.WriteLine("RequesMessage.WriteTo Id =" + cmd.Id() +" / content = " + cmd.Content().getStorageList().ToString());
                writeStorage(localStorage, paramDataOutputStream);
            }
        }

        private void writeStorage(Storage paramStorage, BinaryWriter paramOutputStream)

        {
            byte[] arrayOfByte = new byte[paramStorage.getStorageList().Count];
            Console.WriteLine("ResquestMessage.writeStorage Count: " + paramStorage.getStorageList().Count);
            int i = 0;
            //IEnumerator<byte> localIterator = paramStorage.getStorageList().GetEnumerator();
            IEnumerator<byte> localIterator = paramStorage.getStorageList().GetEnumerator();

            while (localIterator.MoveNext())
            {
                Byte localByte = (Byte)localIterator.Current;
                arrayOfByte[i] = (byte)localByte;
                Console.WriteLine("RequestMessage.WriteStorage byte" + i + ": " + b /*localIterator.Current*/);
                i++;
            } 
            paramOutputStream.Write(arrayOfByte);
            Console.WriteLine("Mandado array");
        }

        public List<Command> Commands()
        {
            return this.commands;
        }
    }

}
