using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCode1 : MonoBehaviour
{
    public AudioSource death;

    private bool danger = false;
    public string damageTag;
    public GameObject myPrefab;
    public GameObject spawnPoint;
    private GameObject[] newWeight;
    private GameObject[] chains;
    private GameObject[] chainFirst;
    public Carrot _carrot;

    // Start is called before the first frame update
    void Start()
    {
        damageTag = "Red";
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(danger.ToString()))
        {

            KillPlayer(collision.gameObject, "Player");

        }
        else if (collision.gameObject.tag.Equals(danger.ToString()))
        {
            KillPlayer(collision.gameObject, "Player");
            //Destroy(gameObject);
            //Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
        }
    }

    public void SetSpawnPoint (GameObject newSpawn)
    {
        spawnPoint = newSpawn;
    }

    public void SetPlayerPrefab(GameObject newPrefab)
    {
        myPrefab = newPrefab;
    }

    public void KillPlayer(GameObject player, string tag) // gets called in objects that kill player, also destroys the chain and spawns player at spawpoint
    {
        if (tag.Equals(danger.ToString()))
        {

            if (player.gameObject.tag.Equals("Player"))
            {
                chainFirst = GameObject.FindGameObjectsWithTag("ChainFirst");
                Destroy(chainFirst[0]);
                chains = GameObject.FindGameObjectsWithTag("Chain");
                newWeight = GameObject.FindGameObjectsWithTag("Weight");
                Destroy(newWeight[0]);
                for (int i = 0; i < chains.Length; i++)
                {
                    print(chains[i].ToString());
                    Destroy(chains[i]);
                }
            }

            Destroy(player);
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
            newWeight = GameObject.FindGameObjectsWithTag("Weight");

        }else if  (tag.Equals(danger.ToString()))
        {
            chainFirst = GameObject.FindGameObjectsWithTag("ChainFirst");
            Destroy(chainFirst[0]);
            chains = GameObject.FindGameObjectsWithTag("Chain");
            newWeight = GameObject.FindGameObjectsWithTag("Weight");
            Destroy(newWeight[0]);
            for (int i = 0; i < chains.Length; i++)
            {
                print(chains[i].ToString());
                Destroy(chains[i]);
            }
            Destroy(player);
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
            newWeight = GameObject.FindGameObjectsWithTag("Weight");
        }


    }

    public void KillPlayerAlways(GameObject player, string tag) // gets called in objects that kill player, also destroys the chain and spawns player at spawpoint
    {
        death.Play();
        if (player.gameObject.tag.Equals("Player"))
        {
            print("Does this happen?");
            chainFirst = GameObject.FindGameObjectsWithTag("ChainFirst");
            Destroy(chainFirst[0]);
            chains = GameObject.FindGameObjectsWithTag("Chain");
            newWeight = GameObject.FindGameObjectsWithTag("Weight");
            Destroy(newWeight[0]);
            for (int i = 0; i < chains.Length; i++)
            {
                print(chains[i].ToString());
                Destroy(chains[i]);
            }
        }
            death.Play();
            Destroy(player);
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
            newWeight = GameObject.FindGameObjectsWithTag("Weight");

        


    }
}
