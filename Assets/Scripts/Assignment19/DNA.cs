using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    public float deg = 0f;
    public float angleIncrement = 1f;

    void Update()
    {
        deg += angleIncrement;
        transform.rotation = Quaternion.Euler(new Vector3(0, deg, 0));

    }
}
