using System.Collections;
using UnityEngine;

public class LoadTrigger : MonoBehaviour {
  public string loadName;
  public string unloadName;

  private void OnTriggerEnter(Collider col) {
    if (!string.IsNullOrEmpty(loadName)) {
      SceneStateManager.Load(loadName);
    }

    if (!string.IsNullOrEmpty(unloadName)) {
      StartCoroutine(UnloadScene());
    }
  }

  IEnumerator UnloadScene() {
    yield return new WaitForSeconds(.10f);
    SceneStateManager.Unload(unloadName);
  }
}
