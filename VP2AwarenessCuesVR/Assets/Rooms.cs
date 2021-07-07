using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rooms : MonoBehaviour
{
    public GameObject roomText;
    public GameObject head;
    public Transform headTransform;
    public GameObject number;
    private GameObject room1;
    private GameObject room2;
    private GameObject room3;
    private GameObject room4;
    private GameObject room5;
    private GameObject room6;
    private GameObject room7;
    private GameObject room8;
    private GameObject room9;
    private GameObject room10;
    private GameObject room11;
    private GameObject room12;
    private GameObject room1Map;
    private GameObject room2Map;
    private GameObject room3Map;
    private GameObject room4Map;
    private GameObject room5Map;
    private GameObject room6Map;
    private GameObject room7Map;
    private GameObject room8Map;
    private GameObject room9Map;
    private GameObject room10Map;
    private GameObject room11Map;
    private GameObject room12Map;
    public Material mRoom1;
    public Material mRoom1On;
    public Material mRoom2;
    public Material mRoom2On;
    public Material mRoom3;
    public Material mRoom3On;
    public Material mRoom4;
    public Material mRoom4On;
    public Material mRoom5;
    public Material mRoom5On;
    public Material mRoom6;
    public Material mRoom6On;
    public Material mRoom7;
    public Material mRoom7On;
    public Material mRoom8;
    public Material mRoom8On;
    public Material mRoom9;
    public Material mRoom9On;
    public Material mRoom10;
    public Material mRoom10On;
    public Material mRoom11;
    public Material mRoom11On;
    public Material mRoom12;
    public Material mRoom12On;
    private bool room1On = false;
    private bool room2On = false;
    private bool room3On = false;
    private bool room4On = false;
    private bool room5On = false;
    private bool room6On = false;
    private bool room7On = false;
    private bool room8On = false;
    private bool room9On = false;
    private bool room10On = false;
    private bool room11On = false;
    private bool room12On = false;
    private float distanceX = -2.74f;
    private float distanceY = 0.19f;
    private float distanceZ = 2.87f;
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        roomText.transform.SetParent(headTransform);
        roomText.transform.position = new Vector3(distanceX, distanceY, distanceZ);
        number.GetComponent<TextMesh>().text = counter.ToString();
        room1 = GameObject.Find("Room1");
        room2 = GameObject.Find("Room2");
        room3 = GameObject.Find("Room3");
        room4 = GameObject.Find("Room4");
        room5 = GameObject.Find("Room5");
        room6 = GameObject.Find("Room6");
        room7 = GameObject.Find("Room7");
        room8 = GameObject.Find("Room8");
        room9 = GameObject.Find("Room9");
        room10 = GameObject.Find("Room10");
        room11 = GameObject.Find("Room11");
        room12 = GameObject.Find("Room12");
        room1Map = GameObject.Find("Room1Map");
        room2Map = GameObject.Find("Room2Map");
        room3Map = GameObject.Find("Room3Map");
        room4Map = GameObject.Find("Room4Map");
        room5Map = GameObject.Find("Room5Map");
        room6Map = GameObject.Find("Room6Map");
        room7Map = GameObject.Find("Room7Map");
        room8Map = GameObject.Find("Room8Map");
        room9Map = GameObject.Find("Room9Map");
        room10Map = GameObject.Find("Room10Map");
        room11Map = GameObject.Find("Room11Map");
        room12Map = GameObject.Find("Room12Map");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("v") && room1On == true){
            room1.GetComponent<MeshRenderer>().material = mRoom1;
            room1Map.GetComponent<MeshRenderer>().material = mRoom1;
            room1On = !room1On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(Input.GetKeyDown("c") && room1On == false){
            room1.GetComponent<MeshRenderer>().material = mRoom1On;
            room1Map.GetComponent<MeshRenderer>().material = mRoom1On;
            room1On = !room1On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room2On == true){
            room2.GetComponent<MeshRenderer>().material = mRoom2;
            room2Map.GetComponent<MeshRenderer>().material = mRoom2;
            room2On = !room2On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room2On == false){
            room2.GetComponent<MeshRenderer>().material = mRoom2On;
            room2Map.GetComponent<MeshRenderer>().material = mRoom2On;
            room2On = !room2On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room3On == true){
            room3.GetComponent<MeshRenderer>().material = mRoom3;
            room3Map.GetComponent<MeshRenderer>().material = mRoom3;
            room3On = !room3On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room3On == false){
            room3.GetComponent<MeshRenderer>().material = mRoom3On;
            room3Map.GetComponent<MeshRenderer>().material = mRoom3On;
            room3On = !room3On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room4On == true){
            room4.GetComponent<MeshRenderer>().material = mRoom4;
            room4Map.GetComponent<MeshRenderer>().material = mRoom4;
            room4On = !room4On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room4On == false){
            room4.GetComponent<MeshRenderer>().material = mRoom4On;
            room4Map.GetComponent<MeshRenderer>().material = mRoom4On;
            room4On = !room4On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room5On == true){
            room5.GetComponent<MeshRenderer>().material = mRoom5;
            room5Map.GetComponent<MeshRenderer>().material = mRoom5;
            room5On = !room5On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room5On == false){
            room5.GetComponent<MeshRenderer>().material = mRoom5On;
            room5Map.GetComponent<MeshRenderer>().material = mRoom5On;
            room5On = !room5On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room6On == true){
            room6.GetComponent<MeshRenderer>().material = mRoom6;
            room6Map.GetComponent<MeshRenderer>().material = mRoom6;
            room6On = !room6On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room6On == false){
            room6.GetComponent<MeshRenderer>().material = mRoom6On;
            room6Map.GetComponent<MeshRenderer>().material = mRoom6On;
            room6On = !room6On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room7On == true){
            room7.GetComponent<MeshRenderer>().material = mRoom7;
            room7Map.GetComponent<MeshRenderer>().material = mRoom7;
            room7On = !room7On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room7On == false){
            room7.GetComponent<MeshRenderer>().material = mRoom7On;
            room7Map.GetComponent<MeshRenderer>().material = mRoom7On;
            room7On = !room7On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room8On == true){
            room8.GetComponent<MeshRenderer>().material = mRoom8;
            room8Map.GetComponent<MeshRenderer>().material = mRoom8;
            room8On = !room8On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room8On == false){
            room8.GetComponent<MeshRenderer>().material = mRoom8On;
            room8Map.GetComponent<MeshRenderer>().material = mRoom8On;
            room8On = !room8On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room9On == true){
            room9.GetComponent<MeshRenderer>().material = mRoom9;
            room9Map.GetComponent<MeshRenderer>().material = mRoom9;
            room9On = !room9On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room9On == false){
            room9.GetComponent<MeshRenderer>().material = mRoom9On;
            room9Map.GetComponent<MeshRenderer>().material = mRoom9On;
            room9On = !room9On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room10On == true){
            room10.GetComponent<MeshRenderer>().material = mRoom10;
            room10Map.GetComponent<MeshRenderer>().material = mRoom10;
            room10On = !room10On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room10On == false){
            room10.GetComponent<MeshRenderer>().material = mRoom10On;
            room10Map.GetComponent<MeshRenderer>().material = mRoom10On;
            room10On = !room10On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room11On == true){
            room11.GetComponent<MeshRenderer>().material = mRoom11;
            room11Map.GetComponent<MeshRenderer>().material = mRoom11;
            room11On = !room11On;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room11On == false){
            room11.GetComponent<MeshRenderer>().material = mRoom11On;
            room11Map.GetComponent<MeshRenderer>().material = mRoom11On;
            room11On = !room11On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
        if(1==1 && room12On == true){
            room12.GetComponent<MeshRenderer>().material = mRoom12;
            room12Map.GetComponent<MeshRenderer>().material = mRoom12;
            room12On = !room12On;
           counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if(1==1 && room12On == false){
            room12.GetComponent<MeshRenderer>().material = mRoom12On;
            room12Map.GetComponent<MeshRenderer>().material = mRoom12On;
            room12On = !room12On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        } 
    }
}
