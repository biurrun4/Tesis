using UnityEngine;
using it.polito.appeal.traci;
using System.Collections;
using System.Collections.Generic;
using de.tudresden.ws.container;
using java.util;
using de.tudresden.sumo.cmd;
using System;
using java.lang;

public class SumoBehaviour : MonoBehaviour
{
    public string sumo_bin;
    public string config_file;
    public GameObject npc,road,intersection,driver;

    private int carnum;
    private SumoStringList carIds,linkIds;
    private IEnumerator<Auto> itCar;
    private SumoPosition2D position;
    private double speed,angle;
    private Auto car;
    private List<Auto> carList;
    private List<Link> linkList;
    private SumoTraciConnection conn;

    void Start()
    {
        try
        {


            config_file = GameObject.FindGameObjectsWithTag("Persistant_Data")[0].GetComponent<persistant_data>().path_to_osm; // read data from menue
            conn = new SumoTraciConnection(sumo_bin, config_file);
            //set some options
            conn.addOption("step-length", "0.1"); //timestep 100 ms
            conn.addOption("start", "");
            conn.runServer();
            conn.do_timestep();

            carList = new List<Auto>();
            linkList = new List<Link>();
            ReadLanes();
            printLanes(linkList);
            //for (int i = 0; i < 300; i++)
            //{
            //    ReadCars();
            //}

            //printCars(carList);

            //Debug.Log("Invoke?");
            //InvokeRepeating("Readcars", 1, 0.3F);
            //Debug.Log("Afterinvoke");
        }
        catch (System.Exception)
        {
            conn.close();
        }
    }
    //public void Update()
    //{
    //    Readcars();
    //}
    void ReadCars() {
        Debug.Log("LLAMANDO");
        carList.Clear();
        /*int simtime = (int)*/
        int simtime = ((Integer) (conn.do_job_get(Simulation.getCurrentTime()))).intValue();
        carIds  = (SumoStringList)conn.do_job_get(Vehicle.getIDList());
        

        foreach (string id in carIds)
        {
            Debug.Log("id:" + id);
            position = (SumoPosition2D)conn.do_job_get(Vehicle.getPosition(id));
            car = new Auto(position.x, position.y, Convert.ToInt32(id));
            speed= ((java.lang.Double) conn.do_job_get(Vehicle.getSpeed(id))).doubleValue();
            angle = ( (java.lang.Double) conn.do_job_get(Vehicle.getAngle(id))).doubleValue() ;
            car.setSpeed(speed);
            car.setAngle(angle);
            carList.Add(car);
        }

        
        //printCars(cars);
        conn.do_timestep();
    }
    void ReadLanes()
    {
        linkIds = (SumoStringList)conn.do_job_get(Lane.getIDList());
        int z = 0;
        foreach (string id in linkIds)  
        {
            //z++;
            //Debug.Log("id:" + id);
            SumoGeometry centers = (SumoGeometry) conn.do_job_get(Lane.getShape(id));
            double width = ((java.lang.Double) conn.do_job_get(Lane.getWidth(id))).doubleValue();
            double length = ((java.lang.Double) conn.do_job_get(Lane.getLength(id))).doubleValue();
            //Debug.Log("Coords: " + centers.coords + "// Width" + width + "// Length" + length);
            linkList.Add(new Link(centers.coords, width, length,id));
            //foreach (SumoPosition2D d2 in obj.coords)
            //{
            //    Debug.Log("Z= " + z+ "// x= "+d2.x + "// y= " + d2.y);
            //}
            //Debug.Log(obj);
            //if (z >= 15) { break; }
        }
    }

    public void printLanes(List<Link> lanes)
    {
        //int i = 0;
        float x,x_prev;
        float z,z_prev;
        float angle,width, length;
        Vector3 middle;
        string id;
        bool instantiated=false;

        foreach (Link lane in lanes)
        {
            id = lane.getID();
            x_prev = -1;
            z_prev = -1;
            width = lane.getWidth();
            LinkedList centers = lane.getCenters();
            foreach (SumoPosition2D center in centers)
            {
                //if (i>4)
                //{
                //    break;
                //}
                x = (float) center.x;
                z = (float) center.y;
                //var temp = Instantiate(intersection, new Vector3(z, 0, x), Quaternion.identity);
                if (x_prev == -1 || z_prev == -1)
                {
                    x_prev = x;
                    z_prev = z;
                }
                else
                {
                    
                    length = (float) System.Math.Sqrt(System.Math.Pow((x - x_prev),2) + System.Math.Pow((z - z_prev),2));
                    middle = new Vector3( (z + z_prev) / 2, 0, (x + x_prev) / 2);
                    angle = (float) (System.Math.Atan((x - x_prev)/ (z - z_prev))* 180 / System.Math.PI);
                    if ((angle == 0) || (angle==90) || (angle ==-90) || (angle == 180))
                    {
                        angle=angle+90; 
                    }
                    GameObject newLane = Instantiate(road, middle, Quaternion.identity) as GameObject;
                    newLane.transform.Rotate(new Vector3(0, angle, 0));
                    newLane.transform.localScale = new Vector3((float)(0.33 * width / 3.2), 1,(float)(0.105 * length));
                    newLane.name = lane.getID();
                    if (!instantiated)
                    {
                        if (id.Equals("start_sim_0"))
                        {
                            Debug.Log("STARTSIM");
                            instantiated = true;
                            GameObject temp = Instantiate(driver, middle, Quaternion.identity) as GameObject;
                            temp.name = "Driver";
                            temp.transform.Rotate(new Vector3(0, angle, 0));
                        }
                    }
                    x_prev = x;
                    z_prev = z;
                    Debug.Log(middle);
                    Debug.Log(angle);
                    //i++;
                }
            }
            
        }
    }

    public void printCars(List<Auto> cars)
    {
        Debug.Log(cars.Count);
        for (int i = 0; i < cars.Count; i++)
        {
            Auto car = cars[i];
            GameObject newCar = Instantiate(npc, car.getPos(), Quaternion.identity) as GameObject;
            newCar.name = "Car_"+car.getId().ToString();
            newCar.transform.Rotate(new Vector3(0,(float) car.getAngle(), 0));
            Debug.Log("car " + car.getId() + " en posicion X=" + car.getX() + " ,Y=" + car.getZ() + " a una velocidad de " + car.getSpeed());
        }
    }
}

