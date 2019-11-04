using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public WeightChange _WeightChange;
    public float newWeight;
    private float oldWeight;
    public float duration = 5.0f;


    private float currentTime = 0f;
    private float startingTime = 5f;

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
        if (collision.CompareTag("Player"))
        {

            StartCoroutine(PickUp(collision));

        }
    }

    IEnumerator PickUp(Collider2D player)
    {
        oldWeight = _WeightChange.GetWeight();
        _WeightChange.SetWeight(newWeight);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        _WeightChange.SetWeight(oldWeight);
        Destroy(gameObject);
    }
}
