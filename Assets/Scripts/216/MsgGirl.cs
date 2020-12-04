using UnityEngine;

public class MsgGirl : MonoBehaviour {
  public GameObject player;
  private bool _logic;

  void OnTriggerEnter(Collider other) {
    if (other.tag == "Player") {
      _logic = true;
    }
  }

  void OnTriggerExit(Collider other) {
    if (other.tag == "Player") {
      _logic = false;
    }
  }

  void OnGUI() {
    if (_logic) {
      GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80),
        "Студентка производит построение диаграммы базы данных.");
    }
  }
}
