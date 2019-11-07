using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCode : MonoBehaviour
{
    public Text uiText;
    public Text uiText2;
    private float currentTime = 0f;
    private float startingTime = 5f;
    private bool danger = false;
    public string damageTag;
    public GameObject myPrefab;
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        damageTag = "Red";
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {

        uiText.text = currentTime.ToString();

        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0f)
        {
            currentTime = 5f;
            danger = !danger;
        }
        if (danger)
        {
            uiText2.text = "Gray Kill";

        }else if (!danger)
        {
            uiText2.text = "Purple Kill";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(danger.ToString()))
        {
            Destroy(gameObject);
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);

        }
        else if (collision.gameObject.tag.Equals(danger.ToString()))
        {
            Destroy(gameObject);
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
        }
    }

    public void KillPlayer(GameObject player, string tag)
    {
        if (tag.Equals(danger.ToString()))
        {
            Instantiate(myPrefab, spawnPoint.transform.position, Quaternion.identity);
            Destroy(player);
        }
    }
}
