using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeAttach1 : MonoBehaviour
{

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
    void lateUpdate()
    {
        for(int i = 0; i < rigidBodies.Count; i++)
        {
            Rigidbody2D rb = rigidBodies[i];
            xV = transform.position.x - lastPosition.x;
            yV = transform.position.y - lastPosition.y;
            test.x = xV;
            test.y = yV;
            Vector2 velocity = (test);
            rb.transform.Translate(velocity, _transform);
        }

        lastPosition = _transform.position;
    }

    private void OnColliderEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            add(rb);
        }
    }
    private void OnColliderExit2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            remove(rb);
        }
    }

    void add(Rigidbody2D rb)
    {
        if (!rigidBodies.Contains(rb))
        {
            rigidBodies.Add(rb);
        }
    }
    void remove(Rigidbody2D rb)
    {
        if (!rigidBodies.Contains(rb))
        {
            rigidBodies.Remove(rb);
        }
    }
}

