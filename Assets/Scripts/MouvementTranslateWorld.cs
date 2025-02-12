using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{

    //public float x = 0f;

    //public float y = 0f;

    //public float z = 0f;

    //void Update()
    //{
    //    transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z*Time.deltaTime, Space.World);

    //    //Vector3 deplacement = new Vector3(1f, 0, 0);
    //    //transform.Translate(deplacement * Time.deltaTime, Space.World);
    //}
    [SerializeField] private Vector3 _deplacement;


    private void Update()
    {

        transform.Translate(_deplacement * Time.deltaTime, Space.World);


    }

}
