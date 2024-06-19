using UnityEngine;

public class Rotator : Changer
{
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, _speed, 0);
    }
}
