using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public GameObject arrow;
    public GameObject head;
    public Transform headTransform;
    private float distance = 2.5f;
    private bool arrowButton0;
    private bool arrowButton1;
    private bool arrowButton2;
    private bool arrowButton3;
    private bool arrowButton4;
    private bool arrowButton5;
    private bool arrowButton6;
    private bool arrowButton7;
    private float timer;
    private float tmp;
    

    // Start is called before the first frame update
    void Start()
    {
        arrow.SetActive(false);
        arrow.transform.SetParent(headTransform);
        arrow.transform.position = head.transform.position + head.transform.forward * distance;
        //getter für arrowButtons
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(arrowButton0 == true){
            arrow.SetActive(true);
            tmp = timer + 3.0f;
        }else if(Input.GetKeyDown("b")){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, -45.0f);
            tmp = timer + 10.0f;
        }else if(arrowButton2 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, -90.0f);
            tmp = timer + 3.0f;
        }else if(arrowButton3 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, -135.0f);
            tmp = timer + 3.0f;
        }else if(arrowButton4 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, 180.0f);
            tmp = timer + 3.0f;
        }else if(arrowButton5 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, 135.0f);
            tmp = timer + 3.0f;
        }else if(arrowButton6 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, 90.0f);
            tmp = timer + 3.0f;
        }else if(arrowButton7 == true){
            arrow.SetActive(true);
            arrow.transform.rotation = Quaternion.Euler(0, 0, 45.0f);
            tmp = timer + 3.0f;
        }
        if(timer > tmp){
            arrow.SetActive(false);
            arrow.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
