using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = -1f;
    [SerializeField] private bool _isLocalMoving = true;
    private Vector3 _position;

    private void Update()
    {
        if (_isLocalMoving)
            LocalMoveForward();
        else
            MoveForward();
    }

    private void MoveForward()
    {
        _position = transform.position;
        _position.z += _speed * Time.deltaTime;
        transform.position = _position;
    }

    private void LocalMoveForward()
    {
        transform.Translate(0, 0, _speed);
    }
}
