using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMap : MonoBehaviour
{
    GameObject Island1; // cube
    GameObject Island1Dome; // cylinder
    GameObject Island2; // cube
    GameObject Island2Dome; // cylinder
    GameObject Person; // capsule
    GameObject Water; // plane

    public void openMap()
    {
        Island1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Island1Dome = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        Island2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Island2Dome = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        Person = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Water = GameObject.CreatePrimitive(PrimitiveType.Plane);

        Island1.transform.position = new Vector3(50f,0f,50f);
        Island1Dome.transform.position = new Vector3(50f,0f,50f);
        Island2.transform.position = new Vector3(-50f,0f,-50f);
        Island2Dome.transform.position = new Vector3(-50f,0f,-50f);
        Person.transform.position = new Vector3(0f,0f,0f);
        Water.transform.position = new Vector3(0f,0f,0f);

        Vector3 islandScaleChange = new Vector3(20f,20f,20f);
        Vector3 islandPositionChange = new Vector3(20f,20f,20f);
        Vector3 waterScaleChange = new Vector3(50f,0f,50f);
        Vector3 waterPositionChange = new Vector3(50f,0,50f);
        Vector3 domeScaleChange = new Vector3(20f,10f,20f);
        Vector3 domePositionChange = new Vector3(20f,10f,20f);
        Vector3 personScale = new Vector3(10f,10f,10f);
        Vector3 personPositionChange = new Vector3(10f,10f,10f);

        Island1.transform.localScale += islandScaleChange;
        Island1.transform.position += islandPositionChange;
        Island1Dome.transform.localScale += domeScaleChange;
        Island1Dome.transform.position += domePositionChange;
        Island2.transform.localScale += islandScaleChange;
        Island2.transform.position += islandPositionChange;
        Island2Dome.transform.localScale += domeScaleChange;
        Island2Dome.transform.position += domePositionChange;
        Water.transform.localScale += waterScaleChange;
        Water.transform.position += waterPositionChange;
        Person.transform.localScale += personScale;
        Person.transform.position += personPositionChange;

        Island1.GetComponent<Renderer>().material.color = Color.black;
        Island1Dome.GetComponent<Renderer>().material.color = Color.green;
        Island2.GetComponent<Renderer>().material.color = Color.black;
        Island2Dome.GetComponent<Renderer>().material.color = Color.green;
        Person.GetComponent<Renderer>().material.color = Color.red;
        Water.GetComponent<Renderer>().material.color = Color.blue;

    }

    public void closeMap()
    {
        Destroy(Island1);
        Destroy(Island1Dome);
        Destroy(Island2);
        Destroy(Island2Dome);
        Destroy(Person);
        Destroy(Water);
    }
}
