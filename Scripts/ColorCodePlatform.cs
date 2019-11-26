using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCodePlatform : MonoBehaviour
{
    public Animator transitionAnim;
    public ColorCode colorTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("FreePlayer"))
        {
            transitionAnim.SetTrigger("death");
            print("Platform Text: " + collision.gameObject.name + "    " + collision.gameObject.tag);
            colorTest.KillPlayer(collision.gameObject, gameObject.tag);
        }
    }
}
