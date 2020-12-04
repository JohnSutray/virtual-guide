using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Curs : MonoBehaviour {

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Start();
        }
    }
}
