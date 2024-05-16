using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get input from arrow keys
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Calculate movement vector without z direction
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f).normalized;

        // Move the player
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
