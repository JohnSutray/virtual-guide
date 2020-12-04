using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Telep_H_216 : MonoBehaviour {
  public Transform cam1;
  RaycastHit rch1;
  public GameObject point;
  private bool visible;

  void Update() {
    var direction = cam1.TransformDirection(Vector3.forward);
    if (
      Input.GetKeyDown(KeyCode.E)
      && Physics.Raycast(cam1.position, direction, out rch1, 3)
      && rch1.collider.GetComponent<Bot>()
    ) {
      visible = true;
    }
  }

  void OnGUI() {
    if (!visible) return;
    GUI.Box(new Rect((Screen.width - 300) / 2, (Screen.height - 300) / 2, 300, 300), "Диалог");
    GUI.Label(new Rect(new Rect((Screen.width - 300) / 2, (Screen.height - 270) / 2, 300, 300)), "?");
    if (GUI.Button(new Rect((Screen.width - 250) / 2, (Screen.height - 250) / 2 + 250, 250, 25), "Отмена")) {
      visible = false;
    }

    if (!GUI.Button(new Rect((Screen.width - 250) / 2, (Screen.height - 300) / 2 + 250, 250, 25),
      "Я хочу войти")) return;
    visible = false;
    SceneManager.LoadScene("216", LoadSceneMode.Additive);
    if (!SceneManager.GetSceneByName("216").isLoaded) return;
    transform.position = point.transform.position;
    SceneManager.UnloadSceneAsync("216");
  }
}
