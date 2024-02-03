using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput,0f ).normalized;

        // Check if there is any input, then move the player
        if (movement.magnitude >= 0.1f)
        {
            MovePlayer(movement);
        }
    }

    void MovePlayer(Vector3 movement)
    {
        // Calculate the target position
        Vector3 targetPosition = transform.position + movement * moveSpeed * Time.deltaTime;

        // Move the player to the target position
        transform.position = targetPosition;
    }
}

