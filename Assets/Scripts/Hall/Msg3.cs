using UnityEngine;
using System.Collections;

public class Msg3 : MonoBehaviour
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
            GUI.TextArea(new Rect(500, 300, 500, 80), "Пройдите в уадиторию №218 (Методы и алгоритмы компьютерной графики)");
            
        }

    }

}