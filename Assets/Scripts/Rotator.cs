using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float _speed = 0.3f;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, _speed, 0);
    }
}
