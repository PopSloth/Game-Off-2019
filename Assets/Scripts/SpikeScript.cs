using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public ColorCode _colordCode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);
        if(collision.CompareTag("Player") || collision.CompareTag("FreePlayer"))
        {
            print("Player Touch");
            _colordCode.KillPlayerAlways(collision.gameObject, collision.transform.tag);
          //  Destroy(collision.gameObject);
        }
    }
}
