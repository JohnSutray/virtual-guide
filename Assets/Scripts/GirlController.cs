using System;
using UnityEngine;

public enum WomanState {
  Idle,
  Start,
  Moving,
  End,
  Sitting
};

public class GirlController : MonoBehaviour {
  public WomanState state = WomanState.Idle;
  public Transform target;
  public Transform sittingPosition;
  public float speed;
  private Animator _animator;
  private bool _playerInActivateArea;
  private static readonly int IsWalking = Animator.StringToHash("isWalking");
  private static readonly int IsSitting = Animator.StringToHash("isSitting");
  private static readonly int IsTyping = Animator.StringToHash("isTyping");

  void Start() => _animator = GetComponent<Animator>();

  void OnTriggerEnter(Collider other) {
    if (other.GetComponent<Collider>().CompareTag("Player")) {
      _playerInActivateArea = true;
    }
  }

  void Update() {
    switch (state) {
      case WomanState.Idle:
        CheckForTrigger();
        break;
      case WomanState.Start:
        _animator.SetBool(IsWalking, true);
        MoveToFinalPoint();
        state = WomanState.Moving;
        break;
      case WomanState.Moving:
        _animator.SetBool(IsWalking, true);
        MoveToFinalPoint();
        CheckForMovingEnd();
        break;
      case WomanState.End:
        _animator.SetBool(IsWalking, false);
        state = WomanState.Sitting;
        _animator.SetBool(IsSitting, true);
        _animator.SetBool(IsTyping, true);
        transform.position = sittingPosition.position;
        break;
      case WomanState.Sitting:
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private void MoveToFinalPoint() => transform.position = Vector3.MoveTowards(
    transform.position,
    target.position,
    speed * Time.deltaTime
  );

  private void CheckForMovingEnd() {
    if (gameObject.transform.position == target.position) {
      state = WomanState.End;
    }
  }

  private void CheckForTrigger() {
    if (_playerInActivateArea) {
      state = WomanState.Start;
    }
  }
}
