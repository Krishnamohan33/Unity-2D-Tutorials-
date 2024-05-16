using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool isReversed = false; // Flag to track if orientation is reversed

    // Update is called once per frame
    void Update()
    {
        // Check if the character is moving left
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            isReversed = true;
            // Reverse the character's orientation to face left
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0) // Check if the character is moving right
        {
            isReversed = false;
            // Reset the character's orientation to face right
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
        }

        // Get input from arrow keys
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Calculate movement vector without z direction
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f).normalized;

        // Move the player
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
