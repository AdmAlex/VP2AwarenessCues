using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxigen : MonoBehaviour
{
    public GameObject oxigen;
    public GameObject oxigenStatus;
    public GameObject head;
    public Transform headTransform;
    private float distanceX = 1.5f;
    private float distanceY = 0.0f;
    private float distanceZ = 1.5f;
    private bool oxigenButton;
    public float timer;
    public float tmp;
    private float nextAction = 0.0f;
    private float period = 1.0f;
    private Vector3 scaleChange = new Vector3(0.0f, 0.0f, 0.0005f);

    // Start is called before the first frame update
    void Start()
    {
        //oxigen.SetActive(false);
        oxigen.transform.SetParent(headTransform);
        oxigen.transform.position = head.transform.position;
        oxigen.transform.position = oxigen.transform.position + new Vector3(distanceX, distanceY, distanceZ);
        //getter für oxigenButton
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > nextAction && timer <= 300.0f) {
            nextAction += period;
            oxigenStatus.transform.localScale =- scaleChange;
        }
        if(timer > 300.0f){
            oxigenStatus.SetActive(false);
        }
    }
}
