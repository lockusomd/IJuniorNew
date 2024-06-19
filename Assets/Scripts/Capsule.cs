using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += new Vector3 (_speed, _speed, _speed) * Time.deltaTime;
    }
}
