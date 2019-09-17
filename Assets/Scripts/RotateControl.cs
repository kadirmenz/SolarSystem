using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    GameObject sun;
    GameObject mercury;
    GameObject venus;
    GameObject earth;
    GameObject mars;
    GameObject jupiter;
    GameObject uranus;
    GameObject saturn;
    GameObject neptune;
    GameObject pluto;

    public float speedMercury;
    public float speedVenus;
    public float speedEarth;
    public float speedMars;
    public float speedJupiter;
    public float speedUranus;
    public float speedSaturn;
    public float speedNeptune;
    public float speedPluto;
    // Start is called before the first frame update
    void Start()
    {
        mercury = GameObject.Find("Mercury");
        venus = GameObject.Find("Venus");
        earth = GameObject.Find("Earth");
        mars = GameObject.Find("Mars");
        jupiter = GameObject.Find("Jupiter");
        uranus = GameObject.Find("Uranus");
        saturn = GameObject.Find("Saturn");
        neptune = GameObject.Find("Neptune");
        pluto = GameObject.Find("Pluto");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mercury.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedMercury * Time.deltaTime);
        venus.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedVenus * Time.deltaTime);
        earth.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedEarth * Time.deltaTime);
        mars.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedMars * Time.deltaTime);
        jupiter.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedJupiter * Time.deltaTime);
        uranus.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedUranus * Time.deltaTime);
        saturn.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedSaturn * Time.deltaTime);
        neptune.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedNeptune * Time.deltaTime);
        pluto.transform.RotateAround(transform.position, new Vector3(0, 0, 1), speedPluto * Time.deltaTime);
    }
}
