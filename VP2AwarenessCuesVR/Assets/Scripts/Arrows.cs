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
            arrow.transform.rotation = Quaternion.Euler(0, 0, 0);
            tmp = timer + 3.0f;
        }else if(arrowButton1 == true){
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

    public void showArrow0(){
        arrowButton0=true;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow1(){
        arrowButton0=false;
        arrowButton1=true;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow2(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=true;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow3(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=true;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow4(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=true;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow5(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=true;
        arrowButton6=false;
        arrowButton7=false;
    }
    
    public void showArrow6(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=true;
        arrowButton7=false;
    }
        public void showArrow7(){
        arrowButton0=false;
        arrowButton1=false;
        arrowButton2=false;
        arrowButton3=false;
        arrowButton4=false;
        arrowButton5=false;
        arrowButton6=false;
        arrowButton7=true;
    }
}
