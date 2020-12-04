using UnityEngine;

public class Door : MonoBehaviour {
  private Animator _animator;
  private static readonly int IsOpen = Animator.StringToHash("isOpen");

  void Start() => _animator = GetComponent<Animator>();

  void OnTriggerEnter(Collider _) => _animator.SetBool(IsOpen, true);

  void OnTriggerExit(Collider _) => _animator.SetBool(IsOpen, false);
}
