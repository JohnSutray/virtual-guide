using UnityEngine;

public class MsgBoy : MonoBehaviour {
  private bool _logic;

  void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player")) {
      _logic = true;
    }
  }

  void OnTriggerExit(Collider other) {
    if (other.CompareTag("Player")) {
      _logic = false;
    }
  }

  void OnGUI() {
    if (_logic) {
      GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80),
        "Студент производит резервное копирование и экспорт базы данных");
    }
  }
}
