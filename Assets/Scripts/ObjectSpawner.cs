using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Google.XR.ARCoreExtensions;

//[RequireComponent(typeof(ARAnchorManager))]
public class ObjectSpawner : MonoBehaviour
{
    private ARAnchorManager anchorManager;
   // private Camera arcamera;
    //private List<ARAnchor> anchors = new List<ARAnchor>();
   // private int positionCount = 0;

    [SerializeField]
    private UnityEngine.UI.Button arWhite;

    [SerializeField]
    private UnityEngine.UI.Button arPink;

    [SerializeField]
    private UnityEngine.UI.Button arPurple;
    ARAnchor anchor;

   // ARAnchorManager.HostCloudAnchor(anchor);


    private ARAnchorManager arAnchorManager = null;
    public GameObject objectToSpawn0;
    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn;
    private PlacementIndicator placementIndicator;
    private int fingerID = -1;
    // Start is called before the first frame update
    public void ToggleState()
    {
        GetComponent<ObjectSpawner>().enabled = !GetComponent<ObjectSpawner>().enabled;
    }
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    #if !UNITY_EDITOR
     fingerID = 0; 
    #endif
    }

    void Awake()
    {
        //arRaycastManager = GetComponent<ARRaycastManager>();
        arAnchorManager = GetComponent<ARAnchorManager>();
    }


    public void toobject0()
    {
        objectToSpawn = objectToSpawn0;
    }
    public void toobject1()
    {
        objectToSpawn = objectToSpawn1;
    }
    public void toobject2()
    {
        objectToSpawn = objectToSpawn2;
    }
    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject(fingerID))    // is the touch on the GUI
        {
         
            return;
        }
        else if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
            //var anchor = arAnchorManager.AddAnchor(new Pose(placementIndicator.transform.position, placementIndicator.transform.rotation));
            //ARAnchor anchor = anchorManager.AddAnchor(new Pose(touchPosition, Quaternion.identity));
           // ARCloudAnchorManager.Instance.QueueAnchor(anchor);
        }
    }
}
