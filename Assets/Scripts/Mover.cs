using UnityEngine;

public class Mover : Changer
{
    private void Update()
    {
            MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(0, 0, _speed);
    }
}
