using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _time;

    private void Awake()
    {
        transform.DOScale(transform.localScale + _direction, _time).SetLoops(-1, LoopType.Yoyo);
    }
}
