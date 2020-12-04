using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour {

    public GameObject monitorObject;

    //void Out(Collider other)
    //{
    //    monitorObject.SetActive(false);
    //}
    

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            this.monitorObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            this.monitorObject.SetActive(false);
        }
    }
}
