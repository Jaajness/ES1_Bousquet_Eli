using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMurs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Cible"))
        {
            print(collision.gameObject.name + " : " + collision.gameObject.tag);
            Destroy(collision.gameObject);
        }

    }

}
