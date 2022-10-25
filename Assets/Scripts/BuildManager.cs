using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance { get; private set; }
    private void Awake()
    {
        Debug.Log("Mgr start");
        Instance = this;
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

    public List<GameObject> turrets;

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label($"Turret Count: {turrets.Count}");
        GUILayout.EndHorizontal();
    }
}
