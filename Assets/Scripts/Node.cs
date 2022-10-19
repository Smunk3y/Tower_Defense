using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Color startColor;

    public Vector3 positionOff;

    private GameObject turret;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Cant built There TODO : DISPLAY ON SCREEN");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOff, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    } 

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }
}
