using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    int Score=0;
    AudioSource coinsound;
    public AudioClip clip;


    void Start()
    {
        coinsound = GetComponent<AudioSource>();
    }
    public void OnCoinClicked()
    {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        coinsound.PlayOneShot(clip);
        StartCoroutine(Example()); //have to wait before destroying the key to give the coin sound a chance to appear

    }


    IEnumerator Example()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);

    }
    public float rotateSpeed=100000000000; //set it in the  inspector

    void Update()
    {
        rotate();
    }


    void rotate()
    {
        transform.Rotate(Vector3.up, Time.deltaTime*150, Space.World);
        // transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
    }
}
