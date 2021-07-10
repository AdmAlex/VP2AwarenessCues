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
    public Sprite sRoom1;
    public Sprite sRoom2;
    public Sprite sRoom3;
    public Sprite sRoom4;
    public Sprite sRoom5;
    public Sprite sRoom6;
    public Sprite sRoom7;
    public Sprite sRoom8;
    public Sprite sRoom9;
    public Sprite sRoom10;
    public Sprite sRoom11;
    public Sprite sRoom12;
    public Sprite sRoom1On;
    public Sprite sRoom2On;
    public Sprite sRoom3On;
    public Sprite sRoom4On;
    public Sprite sRoom5On;
    public Sprite sRoom6On;
    public Sprite sRoom7On;
    public Sprite sRoom8On;
    public Sprite sRoom9On;
    public Sprite sRoom10On;
    public Sprite sRoom11On;
    public Sprite sRoom12On;
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
    private bool boolRoom1;
    private bool boolRoom2;
    private bool boolRoom3;
    private bool boolRoom4;
    private bool boolRoom5;
    private bool boolRoom6;
    private bool boolRoom7;
    private bool boolRoom8;
    private bool boolRoom9;
    private bool boolRoom10;
    private bool boolRoom11;
    private bool boolRoom12;


    // Start is called before the first frame update
    void Start()
    {
        roomText.transform.SetParent(headTransform);
        roomText.transform.position = new Vector3(distanceX, distanceY, distanceZ);
        number.GetComponent<TextMesh>().text = counter.ToString();
        room1 = GameObject.Find("RoomButton1");
        room2 = GameObject.Find("RoomButton2");
        room3 = GameObject.Find("RoomButton3");
        room4 = GameObject.Find("RoomButton4");
        room5 = GameObject.Find("RoomButton5");
        room6 = GameObject.Find("RoomButton6");
        room7 = GameObject.Find("RoomButton7");
        room8 = GameObject.Find("RoomButton8");
        room9 = GameObject.Find("RoomButton9");
        room10 = GameObject.Find("RoomButton10");
        room11 = GameObject.Find("RoomButton11");
        room12 = GameObject.Find("RoomButton12");
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
        
    }
    public void Room1Done(){
        boolRoom1 = !boolRoom1;
        if (boolRoom1 == true){
            room1.GetComponent<Button>().image.sprite = sRoom1On;
            room1Map.GetComponent<MeshRenderer>().material = mRoom1On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom1 == false){
            room1.GetComponent<Button>().image.sprite = sRoom1;
            room1Map.GetComponent<MeshRenderer>().material = mRoom1;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room2Done(){
        boolRoom2 = !boolRoom2;
        if (boolRoom2 == true){
            room2.GetComponent<Button>().image.sprite = sRoom2On;
            room2Map.GetComponent<MeshRenderer>().material = mRoom2On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom2 == false){
            room2.GetComponent<Button>().image.sprite = sRoom2;
            room2Map.GetComponent<MeshRenderer>().material = mRoom2;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room3Done(){
        boolRoom3 = !boolRoom3;
        if (boolRoom3 == true){
            room3.GetComponent<Button>().image.sprite = sRoom3On;
            room3Map.GetComponent<MeshRenderer>().material = mRoom3On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom3 == false){
            room3.GetComponent<Button>().image.sprite = sRoom3;
            room3Map.GetComponent<MeshRenderer>().material = mRoom3;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room4Done(){
        boolRoom4 = !boolRoom4;
        if (boolRoom4 == true){
            room4.GetComponent<Button>().image.sprite = sRoom4On;
            room4Map.GetComponent<MeshRenderer>().material = mRoom4On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom4 == false){
            room4.GetComponent<Button>().image.sprite = sRoom4;
            room4Map.GetComponent<MeshRenderer>().material = mRoom4;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room5Done(){
        boolRoom5 = !boolRoom5;
        if (boolRoom5 == true){
            room5.GetComponent<Button>().image.sprite = sRoom5On;
            room5Map.GetComponent<MeshRenderer>().material = mRoom5On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom5 == false){
            room5.GetComponent<Button>().image.sprite = sRoom5;
            room5Map.GetComponent<MeshRenderer>().material = mRoom5;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room6Done(){
        boolRoom6 = !boolRoom6;
        if (boolRoom6 == true){
            room6.GetComponent<Button>().image.sprite = sRoom6On;
            room6Map.GetComponent<MeshRenderer>().material = mRoom6On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom6 == false){
            room6.GetComponent<Button>().image.sprite = sRoom6;
            room6Map.GetComponent<MeshRenderer>().material = mRoom6;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room7Done(){
        boolRoom7 = !boolRoom7;
        if (boolRoom7 == true){
            room7.GetComponent<Button>().image.sprite = sRoom7On;
            room7Map.GetComponent<MeshRenderer>().material = mRoom7On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom7 == false){
            room7.GetComponent<Button>().image.sprite = sRoom7;
            room7Map.GetComponent<MeshRenderer>().material = mRoom7;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room8Done(){
        boolRoom8 = !boolRoom8;
        if (boolRoom8 == true){
            room8.GetComponent<Button>().image.sprite = sRoom8On;
            room8Map.GetComponent<MeshRenderer>().material = mRoom8On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom8 == false){
            room8.GetComponent<Button>().image.sprite = sRoom8;
            room8Map.GetComponent<MeshRenderer>().material = mRoom8;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room9Done(){
        boolRoom9 = !boolRoom9;
        if (boolRoom9 == true){
            room9.GetComponent<Button>().image.sprite = sRoom9On;
            room9Map.GetComponent<MeshRenderer>().material = mRoom9On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom9 == false){
            room9.GetComponent<Button>().image.sprite = sRoom9;
            room9Map.GetComponent<MeshRenderer>().material = mRoom9;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room10Done(){
        boolRoom10 = !boolRoom10;
        if (boolRoom10 == true){
            room10.GetComponent<Button>().image.sprite = sRoom10On;
            room10Map.GetComponent<MeshRenderer>().material = mRoom10On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom10 == false){
            room10.GetComponent<Button>().image.sprite = sRoom10;
            room10Map.GetComponent<MeshRenderer>().material = mRoom10;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room11Done(){
        boolRoom11 = !boolRoom11;
        if (boolRoom11 == true){
            room11.GetComponent<Button>().image.sprite = sRoom11On;
            room11Map.GetComponent<MeshRenderer>().material = mRoom11On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom11 == false){
            room11.GetComponent<Button>().image.sprite = sRoom11;
            room11Map.GetComponent<MeshRenderer>().material = mRoom11;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }

    public void Room12Done(){
        boolRoom12 = !boolRoom12;
        if (boolRoom12 == true){
            room12.GetComponent<Button>().image.sprite = sRoom12On;
            room12Map.GetComponent<MeshRenderer>().material = mRoom12On;
            counter += 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }else if (boolRoom12 == false){
            room12.GetComponent<Button>().image.sprite = sRoom12;
            room12Map.GetComponent<MeshRenderer>().material = mRoom12;
            counter -= 1;
            number.GetComponent<TextMesh>().text = counter.ToString();
        }
    }
}
