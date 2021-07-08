using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paintable : MonoBehaviour
{
    public GameObject Brush;
    public GameObject Floor;
    public GameObject Arrow;
    public GameObject Waypoint;
    public Camera observerCam;
    public float BrushSize = 0.1f;
    public bool draw = false;
    public bool waypointActive = false;
    public Button button;


    
    
    // Start is called before the first frame update
    void Start()
    {
        Waypoint.SetActive(false);
        Arrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0) && draw==true){

            var Ray = observerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit)){
                var go = Instantiate(Brush, hit.point, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * BrushSize;
            }
        }

        if (Input.GetMouseButton(0) && waypointActive== true){
            var Ray = observerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit)){
                Waypoint.GetComponent<Transform>().position = hit.point;
            }
        }
    }

    public void Draw(){
        
        draw = !draw;
        if(draw ==true){
            button.GetComponentInChildren<Text>().text = "Wegzeichner: Aus";
        }
        else{
            button.GetComponentInChildren<Text>().text = "Wegzeichner: An";
        }
        
    }

    public void DeleteLine(){
        GameObject[] line = GameObject.FindGameObjectsWithTag("Brush");
            foreach(GameObject obj in line) {
                Destroy(obj);
            }
    }

    public void ActivateWaypoint(){
        Waypoint.SetActive(true);
        Arrow.SetActive(true);
        waypointActive = !waypointActive;
    }

}
