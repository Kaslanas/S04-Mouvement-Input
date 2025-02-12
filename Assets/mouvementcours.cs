using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementcours : MonoBehaviour
{

    [SerializeField] private float vitess = 0f;

    private void Start()
    {

       vitess += Random.Range(1f, 10f);


    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(vitess *Time.deltaTime, 0, 0, Space.World);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Finish")){

            Debug.Log(gameObject.name + " a terminé la cours");

        }


        
        


    }
}
