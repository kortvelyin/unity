using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;

public class planetest : MonoBehaviour
{
    [SerializeField]
    private GameObject planePrefab;
    [SerializeField]
    private ARSession aRSession;
    private ARPlane firstPlacedPlane;
    private ARPlaneManager aRPlaneManager;
    // Start is called before the first frame update
    void Awake()
    {
        ARPlaneManager planeManager = GetComponent<ARPlaneManager>();
        foreach (var plane in planeManager.trackables)
        {
            //do something
        }
       // var testplane= ARPlaneManager.AddPlane()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
