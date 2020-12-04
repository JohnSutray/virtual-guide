using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject pauseMenu;
    public bool isPaused;

    void Start() {
        if (!Input.GetKeyDown(KeyCode.P)) return;

        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
    }
}
