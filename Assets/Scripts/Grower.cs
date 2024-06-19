using UnityEngine;

public class Grower : Changer
{
    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
