using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 rotateAmount;
    public float speed;

    void Update()
    {
        transform.Rotate(rotateAmount * speed * Time.deltaTime);
    }
}
