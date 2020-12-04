using UnityEngine.SceneManagement;

public static class SceneStateManager {
  public static void Load(string sceneName) {
    if (!SceneManager.GetSceneByName(sceneName).isLoaded)
      SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
  }

  public static void Unload(string sceneName) {
    if (SceneManager.GetSceneByName(sceneName).isLoaded)
      SceneManager.UnloadSceneAsync(sceneName);
  }
}
