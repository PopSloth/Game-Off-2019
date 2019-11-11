using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeParent : MonoBehaviour
{
    public GameObject player;
    public List<Rigidbody2D> rigidBodies = new List<Rigidbody2D>();
    public Vector2 lastPosition;
    public float xV;
    public float yV;
    public float zV;
    private Vector2 test;
    Transform _transform;

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
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
