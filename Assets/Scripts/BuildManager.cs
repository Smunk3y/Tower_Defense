using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More Than one BuildManager in Scene!");
            return;
        }

        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start()
    {
        turretTobuild = standardTurretPrefab;
    }


    private GameObject turretTobuild;

    public GameObject GetTurretToBuild ()
    {
        return turretTobuild;
    }


}
