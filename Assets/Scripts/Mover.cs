using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = -1f;

    private void Update()
    {
            MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(0, 0, _speed);
    }
}
