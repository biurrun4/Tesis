using container;
using System;
using System.Collections.Generic;
using traci.protocol;

namespace sumo.util
{
    public class SumoCommand
    {
        public Command cmd;
        public List<Object> raw;
        public int input1;
        public int input2;
        public String input3;
        public String info;
        public int response;
        public int output_type;

        public SumoCommand(Object commandID, Object paramObject2, Object paramObject3, Object paramObject4, Object paramObject5)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII(Convert.ToString(paramObject3));
            this.input1 = (Convert.ToInt32(commandID));
            this.input2 = (Convert.ToInt32(paramObject2));
            this.input3 = Convert.ToString(paramObject3);
            this.response = (Convert.ToInt32(paramObject4));
            this.output_type = (Convert.ToInt32(paramObject5));
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(paramObject3);
            this.raw.Add(paramObject4);
            this.raw.Add(paramObject5);
        }

        public SumoCommand(Object commandID, Object paramObject2, Object paramObject3, Object paramObject4, Object paramObject5, String paramString)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII(Convert.ToString(paramObject3));
            this.input1 = ((Convert.ToInt32(commandID)));
            this.input2 = ((Convert.ToInt32(paramObject2)));
            this.input3 = Convert.ToString(paramObject3);
            this.info = paramString;
            this.response = (Convert.ToInt32(paramObject4));
            this.output_type = (Convert.ToInt32(paramObject5));
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(paramObject3);
            this.raw.Add(paramObject4);
            this.raw.Add(paramObject5);
        }

        public SumoCommand(Object commandID, Object paramObject2, Object paramObject3, Object[] array, Object paramObject4, Object paramObject5)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII(Convert.ToString(paramObject3));
            if (array.Length == 1)
            {
                add_type(array[0]);
                add_variable(array[0]);
            }
            else
            {
                this.cmd.Content().writeUnsignedByte(15);
                if (((Convert.ToInt32(commandID)) == 164) && (((Convert.ToInt32(paramObject2)) == 131)))
                {
                    this.cmd.Content().writeInt(2);
                    if (array.Length == 3)
                    {
                        this.cmd.Content().writeUnsignedByte(4);
                        this.cmd.Content().writeStringASCII((String)array[0]);
                        this.cmd.Content().writeDouble(Convert.ToDouble(array[1]));
                        this.cmd.Content().writeUnsignedByte((short)Convert.ToByte(array[2]));
                    }
                    else if (array.Length == 2)
                    {
                        this.cmd.Content().writeUnsignedByte(1);
                        this.cmd.Content().writeDouble(Convert.ToDouble(array[0]));
                        this.cmd.Content().writeDouble(Convert.ToDouble(array[1]));
                    }
                    this.cmd.Content().writeUnsignedByte(1);
                }
                else
                {
                    this.cmd.Content().writeInt(array.Length);
                    for (int i = 0; i < array.Length; i++)
                    {
                        add_type(array[i]);
                        add_variable(array[i]);
                    }
                }
            }
            this.input1 = (Convert.ToInt32(commandID));
            this.input2 = (Convert.ToInt32(commandID));
            this.input3 = Convert.ToString(paramObject3);
            this.response = (Convert.ToInt32(commandID));
            this.output_type = (Convert.ToInt32(commandID));
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(paramObject3);
            this.raw.Add(paramObject4);
            this.raw.Add(paramObject5);
        }

        public SumoCommand(Object commandID, Object paramObject2)
        {
            this.input1 = Convert.ToInt32(commandID);
            this.input2 = Convert.ToInt32(paramObject2);
            this.cmd = new Command((Convert.ToInt32(commandID)));
            add_variable(paramObject2);
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
        }

        public SumoCommand(Object commandID, Object paramObject2, Object paramObject3, Object[] array)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.input1 = Convert.ToInt32(commandID);
            this.input2 = Convert.ToInt32(paramObject2);
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII(Convert.ToString(paramObject3));
            if (Convert.ToInt32(paramObject2) == 69)
            {
                this.cmd.Content().writeUnsignedByte(17);
                for (int i = 0; i < array.Length; i++)
                {
                    add_variable(array[i]);
                }
            }
            else if (Convert.ToInt32(paramObject2) == 87)
            {
                this.cmd.Content().writeUnsignedByte(14);
                SumoStringList localSumoStringList = (SumoStringList)array[0];
                this.cmd.Content().writeInt(localSumoStringList.Count);
                IEnumerator<String> localIterator = localSumoStringList.GetEnumerator();
                while (localIterator.MoveNext())
                {
                    String str = (String)localIterator.Current;
                    this.cmd.Content().writeStringASCII(str);
                }
            }
            else if (((Convert.ToInt32(paramObject2) == 145) || Convert.ToInt32(paramObject2) == 144) || (Convert.ToInt32(paramObject2) == 25))
            {
                this.cmd.Content().writeUnsignedByte(15);
                this.cmd.Content().writeInt(0);
            }
            else
            {
                int j;
                if (Convert.ToInt32(paramObject2) == 163)
                {
                    this.cmd.Content().writeUnsignedByte(5);
                    for (j = 0; j < array.Length; j++)
                    {
                        add_variable(array[j]);
                    }
                }
                else if (Convert.ToInt32(paramObject2) == 161)
                {
                    this.cmd.Content().writeUnsignedByte(1);
                    for (j = 0; j < array.Length; j++)
                    {
                        add_variable(array[j]);
                    }
                }
                else if ((Convert.ToInt32(commandID) == 200) && (Convert.ToInt32(paramObject2) == 128))
                {
                    this.cmd.Content().writeUnsignedByte(15);
                    this.cmd.Content().writeInt(5);
                    add_type(array[3]);
                    add_variable(array[3]);
                    add_type(array[1]);
                    add_variable(array[1]);
                    add_type(array[2]);
                    add_variable(array[2]);
                    add_type(array[4]);
                    add_variable(array[4]);
                    add_type(array[0]);
                    add_variable(array[0]);
                }
                else if ((Convert.ToInt32(commandID) == 199) && (Convert.ToInt32(paramObject2) == 66))
                {
                    this.cmd.Content().writeUnsignedByte(1);
                    add_variable(array[0]);
                    add_variable(array[1]);
                }
                else if ((Convert.ToInt32(commandID) == 199) && (Convert.ToInt32(paramObject2) == 128))
                {
                    this.cmd.Content().writeUnsignedByte(15);
                    this.cmd.Content().writeInt(4);
                    add_type(array[3]);
                    add_variable(array[3]);
                    add_type(array[2]);
                    add_variable(array[2]);
                    add_type(array[4]);
                    add_variable(array[4]);
                    this.cmd.Content().writeUnsignedByte(1);
                    add_variable(array[0]);
                    add_variable(array[1]);
                }
                else
                {
                    this.cmd.Content().writeUnsignedByte(15);
                    this.cmd.Content().writeInt(array.Length);
                    for (j = 0; j < array.Length; j++)
                    {
                        add_type(array[j]);
                        add_variable(array[j]);
                    }
                }
            }
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(paramObject3);
            this.raw.Add(array);
        }

        public SumoCommand(Object commandID, Object paramObject2, Object paramObject3, Object paramObject4)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.input1 = Convert.ToInt32(commandID);
            this.input2 = Convert.ToInt32(paramObject2);
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII(Convert.ToString(paramObject3));
            Object localObject1;
            IEnumerator<Object> localIterator;
            Object localObject2;
            if (paramObject4.GetType().Equals(typeof(StringList)))
            {
                localObject1 = (StringList)paramObject4;
                this.cmd.Content().writeUnsignedByte(14);
                this.cmd.Content().writeInt(((StringList)localObject1).Count);
                localIterator = ((StringList)localObject1).GetEnumerator();
                while (localIterator.MoveNext())
                {
                    localObject2 = (String)localIterator.Current;
                    this.cmd.Content().writeStringASCII((String)localObject2);
                }
            }
            else if (paramObject4.GetType().Equals(typeof(SumoStringList)))
            {
                localObject1 = (SumoStringList)paramObject4;
                this.cmd.Content().writeUnsignedByte(14);
                this.cmd.Content().writeInt(((SumoStringList)localObject1).Count);
                localIterator = ((SumoStringList)localObject1).iterator();
                while (localIterator.MoveNext())
                {
                    localObject2 = (String)localIterator.Current;
                    this.cmd.Content().writeStringASCII((String)localObject2);
                }
            }
            else if (paramObject4.GetType().Equals(typeof(SumoTLSLogic)))
            {
                localObject1 = (SumoTLSLogic)paramObject4;
                this.cmd.Content().writeUnsignedByte(15);
                this.cmd.Content().writeInt(((SumoTLSLogic)localObject1).phases.Count);
                this.cmd.Content().writeUnsignedByte(12);
                this.cmd.Content().writeStringASCII(((SumoTLSLogic)localObject1).subID);
                this.cmd.Content().writeUnsignedByte(9);
                this.cmd.Content().writeInt(0);
                this.cmd.Content().writeUnsignedByte(15);
                this.cmd.Content().writeInt(0);
                this.cmd.Content().writeUnsignedByte(9);
                this.cmd.Content().writeInt(((SumoTLSLogic)localObject1).currentPhaseIndex);
                this.cmd.Content().writeUnsignedByte(9);
                this.cmd.Content().writeInt(((SumoTLSLogic)localObject1).phases.Count);
                localIterator = ((SumoTLSLogic)localObject1).phases.GetEnumerator();
                while (localIterator.MoveNext())
                {
                    localObject2 = (SumoTLSPhase)localIterator.Current;
                    add_variable(localObject2);
                }
            }
            else
            {
                add_type(paramObject4);
                add_variable(paramObject4);
            }
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(paramObject3);
            this.raw.Add(paramObject4);
        }

        public SumoCommand(Object commandID, Object paramObject2, Object[] array, Object paramObject3, Object paramObject4)
        {
            this.cmd = new Command((Convert.ToInt32(commandID)));
            this.input1 = Convert.ToInt32(commandID);
            this.input2 = Convert.ToInt32(paramObject2);
            this.cmd.Content().writeUnsignedByte((Convert.ToInt32(paramObject2)));
            this.cmd.Content().writeStringASCII("");
            if ((Convert.ToInt32(commandID) == 171) && (Convert.ToInt32(paramObject2) == 131) && (array.Length == 4))
            {
                this.cmd.Content().writeUnsignedByte(15);
                this.cmd.Content().writeInt(3);
                bool bool1 = Convert.ToBoolean((Boolean)array[2]);
                bool bool2 = Convert.ToBoolean((Boolean)array[3]);
                if (!bool1)
                {
                    this.cmd.Content().writeUnsignedByte(1);
                }
                else {
                    this.cmd.Content().writeUnsignedByte(0);
                }
                add_variable(array[0]);
                if (!bool1)
                {
                    this.cmd.Content().writeUnsignedByte(1);
                }
                else {
                    this.cmd.Content().writeUnsignedByte(0);
                }
                add_variable(array[1]);
                if (bool2)
                {
                    this.cmd.Content().writeUnsignedByte(1);
                }
                else {
                    this.cmd.Content().writeUnsignedByte(0);
                }
            }
            else if ((Convert.ToInt32(commandID) == 171) && (Convert.ToInt32(paramObject2) == 131) && (array.Length == 5))
            {
                this.cmd.Content().writeUnsignedByte(15);
                this.cmd.Content().writeInt(3);
                String str1 = (String)array[0];
                this.cmd.Content().writeUnsignedByte(4);
                add_variable(str1);
                this.cmd.Content().writeUnsignedByte(0);
                add_variable(array[1]);
                String str2 = (String)array[2];
                this.cmd.Content().writeUnsignedByte(4);
                add_variable(str2);
                this.cmd.Content().writeUnsignedByte(0);
                add_variable(array[3]);
                bool bool3 = Convert.ToBoolean((Boolean)array[4]);
                if (bool3)
                {
                    this.cmd.Content().writeUnsignedByte(1);
                }
                else {
                    this.cmd.Content().writeUnsignedByte(0);
                }
            }
            this.response = Convert.ToInt32(paramObject3);
            this.output_type = Convert.ToInt32(paramObject4);
            this.raw = new List<Object>();
            this.raw.Add(commandID);
            this.raw.Add(paramObject2);
            this.raw.Add(this.input3);
            this.raw.Add(array);
        }

        public Object[] get_raw()
        {
            Object[] arrayOfObject = new Object[this.raw.Count];
            for (int i = 0; i < this.raw.Count; i++)
            {
                arrayOfObject[i] = this.raw[i];
            }
            return arrayOfObject;
        }

        private void add_type(Object paramObject)
        {
            if (paramObject.GetType().Equals(typeof(Int32))) {
                this.cmd.Content().writeUnsignedByte(9);
            } else if (paramObject.GetType().Equals(typeof(String))) {
                this.cmd.Content().writeUnsignedByte(12);
            } else if (paramObject.GetType().Equals(typeof(Double))) {
                this.cmd.Content().writeUnsignedByte(11);
            } else if (paramObject.GetType().Equals(typeof(Byte))) {
                this.cmd.Content().writeUnsignedByte(8);
            } else if (paramObject.GetType().Equals(typeof(SumoColor))) {
                this.cmd.Content().writeUnsignedByte(17);
            } else if (paramObject.GetType().Equals(typeof(SumoGeometry))) {
                this.cmd.Content().writeUnsignedByte(6);
            } else if (paramObject.GetType().Equals(typeof(SumoPosition2D))) {
                this.cmd.Content().writeUnsignedByte(1);
            } else if (paramObject.GetType().Equals(typeof(SumoPosition3D))) {
                this.cmd.Content().writeUnsignedByte(3);
            } else if (paramObject.GetType().Equals(typeof(SumoStopFlags))) {
                this.cmd.Content().writeUnsignedByte(8);
            } else if (paramObject.GetType().Equals(typeof(Boolean))) {
                this.cmd.Content().writeUnsignedByte(7);
            } else if (paramObject.GetType().Equals(typeof(SumoStringList))) {
                this.cmd.Content().writeUnsignedByte(14);
            }
        }

        private void add_variable(Object paramObject)
        {
            if (paramObject.GetType().Equals(typeof(Int32)))
            {
                this.cmd.Content().writeInt(Convert.ToInt32(paramObject));
            }
            else if (paramObject.GetType().Equals(typeof(String)))
            {
                this.cmd.Content().writeStringASCII(Convert.ToString(paramObject));
            }
            else if (paramObject.GetType().Equals(typeof(Double)))
            {
                this.cmd.Content().writeDouble(Convert.ToDouble(paramObject));
            }
            else if (paramObject.GetType().Equals(typeof(Byte)))
            {
                this.cmd.Content().writeByte((short)(Convert.ToByte(paramObject)));
            }
            else if (paramObject.GetType().Equals(typeof(Boolean)))
            {
                bool boolean = Convert.ToBoolean((Boolean)paramObject);
                this.cmd.Content().writeUnsignedByte(boolean ? 1 : 0);
            }
            else
            {
                Object localObject1;
                if (paramObject.GetType().Equals(typeof(SumoColor)))
                {
                    localObject1 = (SumoColor)paramObject;
                    this.cmd.Content().writeByte((short)((SumoColor)localObject1).r);
                    this.cmd.Content().writeByte((short)((SumoColor)localObject1).g);
                    this.cmd.Content().writeByte((short)((SumoColor)localObject1).b);
                    this.cmd.Content().writeByte((short)((SumoColor)localObject1).a);
                }
                else
                {
                    IEnumerator<Object> localIterator;
                    Object localObject2;
                    if (paramObject.GetType().Equals(typeof(SumoGeometry)))
                    {
                        localObject1 = (SumoGeometry)paramObject;
                        this.cmd.Content().writeUnsignedByte(((SumoGeometry)localObject1).coords.Count);
                        localIterator = ((SumoGeometry)localObject1).coords.GetEnumerator();
                        while (localIterator.MoveNext())
                        {
                            localObject2 = (SumoPosition2D)localIterator.Current;
                            this.cmd.Content().writeDouble(((SumoPosition2D)localObject2).x);
                            this.cmd.Content().writeDouble(((SumoPosition2D)localObject2).y);
                        }
                    }
                    else if (paramObject.GetType().Equals(typeof(SumoPosition2D)))
                    {
                        localObject1 = (SumoPosition2D)paramObject;
                        this.cmd.Content().writeDouble(((SumoPosition2D)localObject1).x);
                        this.cmd.Content().writeDouble(((SumoPosition2D)localObject1).y);
                    }
                    else if (paramObject.GetType().Equals(typeof(SumoTLSPhase)))
                    {
                        localObject1 = (SumoTLSPhase)paramObject;
                        this.cmd.Content().writeUnsignedByte(9);
                        this.cmd.Content().writeInt(((SumoTLSPhase)localObject1).duration);
                        this.cmd.Content().writeUnsignedByte(9);
                        this.cmd.Content().writeInt(((SumoTLSPhase)localObject1).duration1);
                        this.cmd.Content().writeUnsignedByte(9);
                        this.cmd.Content().writeInt(((SumoTLSPhase)localObject1).duration2);
                        this.cmd.Content().writeUnsignedByte(12);
                        this.cmd.Content().writeStringASCII(((SumoTLSPhase)localObject1).phasedef);
                    }
                    else if (paramObject.GetType().Equals(typeof(SumoStringList)))
                    {
                        localObject1 = (SumoStringList)paramObject;
                        this.cmd.Content().writeInt(((SumoStringList)localObject1).Count);
                        localIterator = ((SumoStringList)localObject1).GetEnumerator();
                        while (localIterator.MoveNext())
                        {
                            localObject2 = (String)localIterator.Current;
                            this.cmd.Content().writeStringASCII((String)localObject2);
                        }
                    }
                    else if (paramObject.GetType().Equals(typeof(SumoStopFlags)))
                    {
                        localObject1 = (SumoStopFlags)paramObject;
                        this.cmd.Content().writeByte((short)((SumoStopFlags)localObject1).getID());
                    }
                }
            }
        }

        public Command get_command()
        {
            return this.cmd;
        }
    }
}
