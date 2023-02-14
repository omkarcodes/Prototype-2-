using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    

    // Update is called once per frame
    void Update()
    {
        new WaitForSeconds(3f);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            StartCoroutine(SpaceKeyPress());
        }
    }
    IEnumerator SpaceKeyPress()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);    
        yield return null;
    }
}
