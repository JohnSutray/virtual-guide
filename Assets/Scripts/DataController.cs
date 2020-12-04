using UnityEngine;

public class DataController : MonoBehaviour {
  public RoundData[] allRoundData;

  void Start() => DontDestroyOnLoad(gameObject);

  public RoundData GetCurrentRoundData() {
    return allRoundData[0];
  }
}
