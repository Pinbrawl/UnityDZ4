using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _lookSpeed;

    private PlayerInput _input;
    private Vector2 _moveDirection;
    private Vector2 _lookDirection;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Update()
    {
        _moveDirection = _input.Player.Move.ReadValue<Vector2>();
        _lookDirection = _input.Player.Look.ReadValue<Vector2>();

        Move();
        Look();
    }

    private void Move()
    {
        if (_lookDirection.sqrMagnitude < 0.1f)
            return;

        float scaledLookSpeed = _lookSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(-_lookDirection.y, _lookDirection.x, 0) * scaledLookSpeed;

        transform.Rotate(offset);
    }

    private void Look()
    {
        if (_moveDirection.sqrMagnitude < 0.1f)
            return;

        float scaledMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(_moveDirection.x, 0, _moveDirection.y) * scaledMoveSpeed;

        transform.Translate(offset);
    }
}
