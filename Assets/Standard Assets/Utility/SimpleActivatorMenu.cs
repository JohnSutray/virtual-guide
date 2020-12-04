using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility {
    public class SimpleActivatorMenu : MonoBehaviour {
        public Text camSwitchButton;
        public GameObject[] objects;

        private int _mCurrentActiveObject;

        private void OnEnable() {
            _mCurrentActiveObject = 0;
            UpdateCameraSwitchButtonText();
        }

        private void UpdateCameraSwitchButtonText() =>
            camSwitchButton.text = objects[_mCurrentActiveObject].name;


        public void NextCamera() {
            var nextActiveObject = _mCurrentActiveObject + 1 >= objects.Length
                ? 0
                : _mCurrentActiveObject + 1;

            for (var i = 0; i < objects.Length; i++) {
                objects[i].SetActive(i == nextActiveObject);
            }

            _mCurrentActiveObject = nextActiveObject;
            UpdateCameraSwitchButtonText();
        }
    }
}
