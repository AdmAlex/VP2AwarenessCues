using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxigen : MonoBehaviour
{
    public GameObject oxigen;
    public GameObject oxigenStatus;
    public GameObject oxigenObserver;
    public GameObject oxigenStatusObserver;
    public GameObject head;
    public Transform headTransform;
    public bool active = false;
    private float distanceX = 0.9f;
    private float distanceY = 0.0f;
    private float distanceZ = 0.9f;
    private bool oxigenButton;
    private float timer;
    private float tmp;
    private float nextAction = 0.0f;
    private float period = 1.0f;
    private Vector3 scaleChange = new Vector3(0.0f, 0.0f, 0.0003f);
    private Vector3 positionChange = new Vector3(0.0f, 0.00145f, 0.0f);
    private Vector3 observerScaleChange = new Vector3(0.0f, 0.003f, 0.0f);
    private Vector3 observerPositionChange = new Vector3(0.0f, 0.91f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        oxigen.SetActive(false);
        oxigen.transform.SetParent(headTransform);
        oxigen.transform.position = head.transform.position;
        oxigen.transform.position = oxigen.transform.position + new Vector3(distanceX, distanceY, distanceZ);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > nextAction && timer <= 295.0f) {
            nextAction += period;
            oxigenStatus.transform.localScale -= scaleChange;
            oxigenStatus.transform.position -= positionChange;
            oxigenStatusObserver.transform.localScale -= observerScaleChange;
            oxigenStatusObserver.transform.position -= observerPositionChange;
        }
        if(timer > 295.0f){
            oxigenStatus.SetActive(false);
            oxigenStatusObserver.SetActive(false);
        }
    }

    public void ShowOxigen(){
        active = !active;
        oxigen.SetActive(active);
    }
}
