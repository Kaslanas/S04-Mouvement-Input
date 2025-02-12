using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(Time.deltaTime * 1000f, Time.deltaTime * 1000f, Time.deltaTime * 1000f, Space.World);
    }
}
