using UnityEngine;
using it.polito.appeal.traci;
using System.Collections;
using test;
using System.Collections.Generic;
using de.tudresden.ws.container;
using java.util;
using de.tudresden.sumo.cmd;
using System;

public class SumoBehaviour : MonoBehaviour
{
    public string sumo_bin;
    public string config_file;
    private int carnum;
    private SumoStringList carIds;
    private IEnumerator<Auto> itCar;
    private SumoPosition2D position;
    private double speed;
    private Auto coche;
    private List<Auto> coches;
    private SumoTraciConnection conn;

    void Start()
    {
        conn = new SumoTraciConnection(sumo_bin, config_file);
        //set some options
        conn.addOption("step-length", "0.1"); //timestep 100 ms
        conn.addOption("start", "");
        conn.runServer();
        for (int i = 0; i < 10000; i++)
        {
            conn.do_timestep();
        }
        conn.do_timestep();
        coches = new List<Auto>();
        Debug.Log("Sos puto?");
       // InvokeRepeating("ReadCoches", 1, 0.3F);
        Debug.Log("Si, mucho");
    }

    void ReadCoches() {
        Debug.Log("LLAMANDO");
        coches.Clear();
        int simtime = (int)conn.do_job_get(Simulation.getCurrentTime());
        carIds = (SumoStringList)conn.do_job_get(Vehicle.getIDList());
        foreach(string id in carIds)
        {
            Debug.Log(id + " ");
            position = (SumoPosition2D)conn.do_job_get(Vehicle.getPosition(id));
            coche = new Auto(position.x, position.y, Convert.ToInt32(id));
            speed = (Double)conn.do_job_get(Vehicle.getSpeed(id));
            coche.setSpeed(speed);
            coches.Add(coche);
        }
        pintarCoches(coches);
        conn.do_timestep();
    }

    public void pintarCoches(List<Auto> coches)
    {
        for (int i = 0; i < coches.Count; i++)
        {
            Auto coche = coches[i];
            Debug.Log("Coche " + coche.getId() + " en posicion X=" + coche.getX() + " ,Y=" + coche.getY() + " a una velocidad de " + coche.getSpeed());
        }
    }
}

