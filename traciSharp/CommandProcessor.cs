using container;
using sumo.util;
using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using traci.protocol;

namespace traciSharp
{
    public class CommandProcessor : Query
    {
        //int temp;


        public CommandProcessor(Socket paramSocket) : base(paramSocket)
        {

        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public /*synchronized*/ void do_job_set(SumoCommand paramSumoCommand)

        {
            queryAndVerifySingle(paramSumoCommand.cmd);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public /*synchronized*/ Object do_job_get(SumoCommand paramSumoCommand)

        {
            Object localObject1 = null;
            ResponseContainer localResponseContainer = queryAndVerifySingle(paramSumoCommand.cmd);
            Command localCommand = localResponseContainer.getResponse();
            verifyGetVarResponse(localCommand, paramSumoCommand.response, paramSumoCommand.input2, paramSumoCommand.input3);
            verify("", Convert.ToInt32(paramSumoCommand.output_type), Convert.ToInt32(localCommand.Content().readUnsignedByte()));
            if (paramSumoCommand.output_type == 9)
            {
                localObject1 = Convert.ToInt32(localCommand.Content().readInt());
            }
            else if (paramSumoCommand.output_type == 11)
            {
                localObject1 = Convert.ToDouble(localCommand.Content().readDouble());
            }
            else if (paramSumoCommand.output_type == 12)
            {
                localObject1 = localCommand.Content().readStringUTF8();
            }
            else
            {
                double d1;
                double d3;
                if (paramSumoCommand.output_type == 1)
                {
                    d1 = localCommand.Content().readDouble();
                    d3 = localCommand.Content().readDouble();
                    localObject1 = new SumoPosition2D(d1, d3);
                }
                else
                {
                    double d6;
                    if (paramSumoCommand.output_type == 3)
                    {
                        d1 = localCommand.Content().readDouble();
                        d3 = localCommand.Content().readDouble();
                        d6 = localCommand.Content().readDouble();
                        localObject1 = new SumoPosition3D(d1, d3, d6);
                    }
                    else if (paramSumoCommand.output_type == 14)
                    {
                        SumoStringList localSumoStringList = new SumoStringList();
                        int k = localCommand.Content().readInt();
                        for (int i1 = 0; i1 < k; i1++)
                        {
                            localSumoStringList.add(localCommand.Content().readStringASCII());
                        }
                        localObject1 = localSumoStringList;
                    }
                    else if (paramSumoCommand.output_type == 5)
                    {
                        double d2 = localCommand.Content().readDouble();
                        double d4 = localCommand.Content().readDouble();
                        d6 = localCommand.Content().readDouble();
                        double d8 = localCommand.Content().readDouble();
                        localObject1 = new SumoBoundingBox(d2, d4, d6, d8);
                    }
                    else
                    {
                        Object localObject3;
                        if (paramSumoCommand.input2 == 181)
                        {
                            int i = localCommand.Content().readByte();
                            localObject3 = new SumoStopFlags((byte)i);
                            localObject1 = localObject3;
                            if (paramSumoCommand.info.Equals("isStopped"))
                            {
                                localObject1 = Convert.ToBoolean(((SumoStopFlags)localObject3).stopped);
                            }
                            if (paramSumoCommand.info.Equals("isStoppedTriggered"))
                            {
                                localObject1 = Convert.ToBoolean(((SumoStopFlags)localObject3).triggered);
                            }
                            if (paramSumoCommand.info.Equals("isAtContainerStop"))
                            {
                                localObject1 = Convert.ToBoolean(((SumoStopFlags)localObject3).isContainerStop);
                            }
                            if (paramSumoCommand.info.Equals("isStoppedParking"))
                            {
                                localObject1 = Convert.ToBoolean(((SumoStopFlags)localObject3).getID() == 12);
                            }
                            if (paramSumoCommand.info.Equals("isAtBusStop"))
                            {
                                localObject1 = Convert.ToBoolean(((SumoStopFlags)localObject3).isBusStop);
                            }
                        }
                        else
                        {
                            int i3;
                            if (paramSumoCommand.output_type == 15)
                            {
                                Object localObject2 = null;
                                int i2;
                                int i7;
                                int i8;
                                Object localObject4;
                                if (paramSumoCommand.input2 == 39)
                                {
                                    localObject3 = new SumoLinkList();
                                    localCommand.Content().readUnsignedByte();
                                    localCommand.Content().readInt();
                                    i2 = localCommand.Content().readInt();
                                    localObject2 = new StringList[i2];
                                    for (int i4 = 0; i4 < i2; i4++)
                                    {
                                        localCommand.Content().readUnsignedByte();
                                        i7 = localCommand.Content().readInt();
                                        for (i8 = 0; i8 < i7; i8++)
                                        {
                                            localCommand.Content().readUnsignedByte();
                                            localCommand.Content().readInt();
                                            String str4 = localCommand.Content().readStringASCII();
                                            localObject4 = localCommand.Content().readStringASCII();
                                            String str5 = localCommand.Content().readStringASCII();
                                            ((SumoLinkList)localObject3).add(new SumoLink(str4, (String)localObject4, str5));
                                        }
                                    }
                                    localObject1 = localObject3;
                                }
                                else
                                {
                                    int m;
                                    int i9;
                                    int i10;
                                    if (paramSumoCommand.input2 == 43)
                                    {
                                        localCommand.Content().readUnsignedByte();
                                        localCommand.Content().readInt();
                                        m = localCommand.Content().readInt();
                                        for (i2 = 0; i2 < m; i2++)
                                        {
                                            localCommand.Content().readUnsignedByte();
                                            String str1 = localCommand.Content().readStringASCII();
                                            localCommand.Content().readUnsignedByte();
                                            i7 = localCommand.Content().readInt();
                                            localCommand.Content().readUnsignedByte();
                                            i8 = localCommand.Content().readInt();
                                            localCommand.Content().readUnsignedByte();
                                            i9 = localCommand.Content().readInt();
                                            localObject4 = new SumoTLSLogic(str1, i7, i8, i9);
                                            localCommand.Content().readUnsignedByte();
                                            i10 = localCommand.Content().readInt();
                                            for (int i11 = 0; i11 < i10; i11++)
                                            {
                                                localCommand.Content().readUnsignedByte();
                                                int i12 = localCommand.Content().readInt();
                                                localCommand.Content().readUnsignedByte();
                                                int i13 = localCommand.Content().readInt();
                                                localCommand.Content().readUnsignedByte();
                                                int i14 = localCommand.Content().readInt();
                                                localCommand.Content().readUnsignedByte();
                                                String str8 = localCommand.Content().readStringASCII();
                                                ((SumoTLSLogic)localObject4).add(new SumoTLSPhase(i12, i13, i14, str8));
                                            }
                                            localObject1 = localObject4;
                                        }
                                    }
                                    else
                                    {
                                        int i5;
                                        if (paramSumoCommand.input2 == 51)
                                        {
                                            localCommand.Content().readUnsignedByte();
                                            localCommand.Content().readInt();
                                            m = localCommand.Content().readInt();
                                            SumoLinkList localSumoLinkList = new SumoLinkList();
                                            for (i5 = 0; i5 < m; i5++)
                                            {
                                                localCommand.Content().readUnsignedByte();
                                                String str2 = localCommand.Content().readStringASCII();
                                                localCommand.Content().readUnsignedByte();
                                                String str3 = localCommand.Content().readStringASCII();
                                                localCommand.Content().readUnsignedByte();
                                                i9 = (byte)localCommand.Content().readUnsignedByte();
                                                localCommand.Content().readUnsignedByte();
                                                byte b = (byte)localCommand.Content().readUnsignedByte();
                                                localCommand.Content().readUnsignedByte();
                                                i10 = (byte)localCommand.Content().readUnsignedByte();
                                                localCommand.Content().readUnsignedByte();
                                                String str6 = localCommand.Content().readStringASCII();
                                                localCommand.Content().readUnsignedByte();
                                                String str7 = localCommand.Content().readStringASCII();
                                                localCommand.Content().readUnsignedByte();
                                                double d9 = localCommand.Content().readDouble();
                                                localSumoLinkList.add(new SumoLink(str2, str3, (byte)i9, b, (byte)i10, d9, str6, str7)); //CUIDADO
                                            }
                                            localObject1 = localSumoLinkList;
                                        }
                                        else
                                        {
                                            m = localCommand.Content().readInt();
                                            Object[] localObject5 = new Object[m];
                                            for (i3 = 0; i3 < m; i3++)
                                            {
                                                i5 = localCommand.Content().readUnsignedByte();
                                                localObject5[i3] = get_value(i5, localCommand);
                                            }
                                            localObject1 = localObject5;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                int j;
                                if (paramSumoCommand.output_type == 6)
                                {
                                    j = localCommand.Content().readUnsignedByte();
                                    SumoGeometry localSumoGeometry = new SumoGeometry();
                                    for (i3 = 0; i3 < j; i3++)
                                    {
                                        double d5 = Convert.ToDouble((Double)get_value(11, localCommand));
                                        double d7 = Convert.ToDouble((Double)get_value(11, localCommand));
                                        localSumoGeometry.add(new SumoPosition2D(d5, d7));
                                    }
                                    localObject1 = localSumoGeometry;
                                }
                                else if (paramSumoCommand.output_type == 17)
                                {
                                    j = localCommand.Content().readUnsignedByte();
                                    int n = localCommand.Content().readUnsignedByte();
                                    i3 = localCommand.Content().readUnsignedByte();
                                    int i6 = localCommand.Content().readUnsignedByte();
                                    localObject1 = new SumoColor(j, n, i3, i6);
                                }
                                else if (paramSumoCommand.output_type == 7)
                                {
                                    localObject1 = Convert.ToInt16(localCommand.Content().readUnsignedByte());
                                }
                            }
                        }
                    }
                }
            }
            return localObject1;
        }

        private Object get_value(int paramInt, Command paramCommand)
        {
            Object localObject = Convert.ToInt32(-1);
            if (paramInt == 12)
            {
                localObject = paramCommand.Content().readStringASCII();
            }
            else if (paramInt == 9)
            {
                localObject = Convert.ToInt32(paramCommand.Content().readInt());
            }
            else if (paramInt == 7)
            {
                localObject = Convert.ToInt16(paramCommand.Content().readUnsignedByte());
            }
            else if (paramInt == 11)
            {
                localObject = Convert.ToDouble(paramCommand.Content().readDouble());
            }
            else {
                //UnityEngine.Debug.Log("unknown: " + paramInt);
            }
            return localObject;
        }

        protected static String verifyGetVarResponse(Command paramCommand, int paramInt1, int paramInt2, String paramString)
        {
            verify("response code", Convert.ToInt32(paramInt1), Convert.ToInt32(paramCommand.Id()));
            verify("variable ID", Convert.ToInt32(paramInt2), Convert.ToInt32(paramCommand.Content().readUnsignedByte()));
            String str = paramCommand.Content().readStringASCII();
            if (paramString != null) {
                verify("object ID", paramString, str);
            }
            return str;
        }
    }
}
