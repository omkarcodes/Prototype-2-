using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable Declaration
    public float horizontalInput; //for the horizontal input
    public float verticalInput;
    float xRange = 10f;    //for the range to bound the player to the screen so that it should not fall down 
    float zRange = 11f;
    float speed = 20f;    // speed for the movement of the player
    

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");  //Get the axis for a boolean value
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime); //code for movement of the player in x axis
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    }
    // LateUpdate is called after the update function

    private void LateUpdate()
    {
        //if() statement for keeping the player in the negative x axis 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //keeping the position same as the range of the screen 
        }
        //another if() statement for keeping the player in the positive x axis
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); //keeping the position same as the range of the screen 
        }
        if (transform.position.z < -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1); //keeping the position same as the range of the screen 
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange); //keeping the position same as the range of the screen 
        }


        if (Input.GetKeyDown(KeyCode.Joystick1Button7) || Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
