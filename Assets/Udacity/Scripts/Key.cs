using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door

    bool taken = false;
     AudioSource keysound;
    public AudioClip clip;



    void Start()
    {
        keysound = GetComponent<AudioSource>();

    }

    void Update()
    {
        rotate();
    }
   

    public void OnKeyClicked()
	{
        taken = true;
        keysound.PlayOneShot(clip);
        StartCoroutine(Example()); //have to wait before destroying the key to give the key sound a chance to appear
       
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);

    }

    public bool get_key()
    {
        return taken;
    }


    void rotate()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 150, Space.World);
         //transform.Rotate(0,  Time.deltaTime, 0, Space.World);
    }
}
