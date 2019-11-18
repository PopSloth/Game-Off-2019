using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetWeight(float newWeight)
    {
        gameObject.GetComponent<Rigidbody2D>().mass = newWeight;
    }

    public void SetBreak(float newBreak)
    {
        gameObject.GetComponent<HingeJoint2D>().breakForce = newBreak;
        gameObject.GetComponent<HingeJoint2D>().breakTorque = newBreak;
    }
    public float GetWeight()
    {
        return gameObject.GetComponent<Rigidbody2D>().mass;
    }
    public void SetGravity(float newGravity)
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = newGravity;
    }
}
