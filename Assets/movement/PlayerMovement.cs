using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f; // how fast it moves 
    public float gravity = -9.81f; // the force that pulles down
    public float jumpHeight = 2f; // how high it jumps 

    private CharacterController controller; // helps move the character 
    private Vector3 velocity; // current movement speed 
    private bool isGrounded; // are we standing on the ground? 

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
{
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y <0)

    {
        //small value keeps player on ground
        velocity.y = -2f; 
    }

    float x= Input.GetAxis("Horizontal"); //movement
    float z= Input.GetAxis("Vertical");
    
    Vector3 move = transform.right * x + transform.forward * z; 
    controller.Move(move* speed * Time.deltaTime);

    if (Input.GetButtonDown("Jump") && isGrounded) //jumping
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
    //apply the gravity 
    velocity.y += gravity * Time.deltaTime; 

    //apply vertical movement 
    controller.Move(velocity * Time.deltaTime); 
}
}
