using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

	// Use this for initialization
	void Awake ()
    {
        floorMask = LayerMask.GetMask("Floor");

        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
	
	}
	
	void FixedUpdate ()
    {
        float up = Input.GetAxisRaw("Horizontal");
        float down = Input.GetAxisRaw("Vertical");

        Move (up, down);

        Turning();

        Animating(up, down);
	}

    void Move (float up, float down)
    {
        movement.Set(up, 0f, down);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Turning ()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;

            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

            playerRigidbody.MoveRotation(newRotation);

        }
    }
    
    void Animating (float up, float down)
    {
        bool walking = up != 0f || down != 0f;

        anim.SetBool("IsWalking", walking);
    }
}
