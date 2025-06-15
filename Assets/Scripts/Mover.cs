using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _time;

    private void Awake()
    {
        transform.DOMove(transform.position + _direction, _time, false).SetLoops(-1, LoopType.Yoyo);
    }
}
