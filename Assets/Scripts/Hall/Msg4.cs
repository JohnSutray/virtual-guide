using UnityEngine;
using System.Collections;

public class Msg4 : MonoBehaviour
{


    public GameObject player;
    private bool logic;

     void OnTriggerEnter(Collider other)
     {
        if (other.tag == "Player")
        {
            logic = true;
        }
     }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            logic = false;
        }
    }

    void OnGUI()
    {
        if (logic == true)
        {
            GUI.TextArea(new Rect(500, 300, 400, 60), "Кабинет №217 открыт только для пероснала кафедры ПОВТиАС и преподавателей!");
            
        }

    }

}