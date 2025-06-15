using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _time;

    private void Awake()
    {
        transform.DORotate(transform.rotation.eulerAngles + _direction, _time).SetLoops(-1, LoopType.Yoyo);
    }
}
