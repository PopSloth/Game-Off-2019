using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public GameObject spawnPointFree;
    public GameObject freePlayer;
    private WeightChange _WeightChange;
    private WeightChange _WeightChange2;
    public ColorCode _ColorCode;
    public float newWeight;
    public float breakValue;
    public float gravityValue;
    public float duration = 5.0f;
    private GameObject[] chainFirst;
    private GameObject chainTemp;

    private float oldWeight;


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

    IEnumerator PickUp(Collider2D player) //find first link of chain and change it's break limit also changes to new spawnpoint and new prefab to unchained player
    {
        _ColorCode.SetSpawnPoint(spawnPointFree);
        _ColorCode.SetPlayerPrefab(freePlayer);
        chainFirst = GameObject.FindGameObjectsWithTag("ChainFirst");
        chainTemp = (GameObject)chainFirst.GetValue(0);
        _WeightChange = chainTemp.GetComponent<WeightChange>();
        _WeightChange2 = chainTemp.GetComponent<WeightChange>();

        oldWeight = _WeightChange.GetWeight();
        _WeightChange.SetWeight(newWeight);
        _WeightChange.SetBreak(breakValue);
        _WeightChange2.SetGravity(gravityValue);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        _WeightChange.SetWeight(oldWeight);
        Destroy(gameObject);
    }

    public void SetChain(GameObject chain)
    {
        _WeightChange = chain.GetComponent<WeightChange>();
        _WeightChange2 = chain.GetComponent<WeightChange>();
    }
}
