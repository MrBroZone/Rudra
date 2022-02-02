using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // creates and assignes a constant speed of movements of character
    public float speed = 5f;
    // creates an instance of the rigidbody I have attached on my object
    public Rigidbody2D rb;
    // creates an instance of the camera
    public Camera cam;

    // creates a variable names movement
    Vector2 movement;
    //  creates a variable names pos
    Vector2 pos;
    // Update is called once per frame
    void Update()
    {
        // takes in the left and right movement from the user
        movement.x = Input.GetAxisRaw("Horizontal");
        // takes in the up and down movement from the user
        movement.y = Input.GetAxisRaw("Vertical");
        
        // calculates mouse position by taking in position of mouse as a pixelpoint and changing it to world point
        pos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    void FixedUpdate(){
        
        rb.MovePosition( rb.position + movement * speed * Time.fixedDeltaTime);
        

        Vector2 dir = pos - rb.position;
        
        // Atan2 calculates the angle between the corresponding (perpendicular and base )and the mouse position
        float angle = Mathf.Atan2(dir.y , dir.x) * Mathf.Rad2Deg - 90f;
        // assigns the found value to the z of character rotation
        rb.rotation = angle;
        
    }
}
