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

    public GameObject mgrInstance;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void Update()
    {
        if (BuildManager.Instance == null)
        {
            Instantiate(mgrInstance);
            Debug.LogError("NO BUILD MANAGER");
        }
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.LogError("Cant built There TODO : DISPLAY ON SCREEN");
            return;
        }

        GameObject turretToBuild = BuildManager.Instance.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + positionOff, transform.rotation);
        BuildManager.Instance.turrets.Add(turret);
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
