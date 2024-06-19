using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] float _speed = 0.3f;

    private void Update()
    {
        Spin();
    }

    private void Spin()
    {
        transform.Rotate(0, _speed, 0);
    }
}
