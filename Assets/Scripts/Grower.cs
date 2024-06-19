using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
