using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public float forceMagnitude = 10.0f; // Magnitude of the force to simulate gravity shift
    //public Vector3 torque = new Vector3(0, 1, 0); // Torque to rotate the player

    private ConstantForce constantForce;

    void Start()
    {
        if (player != null)
        {
            constantForce = player.AddComponent<ConstantForce>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && Input.GetKeyDown(KeyCode.Return)) // Check for Enter key press
        {
            if (constantForce != null)
            {
                // Determine the right side of the player
                Vector3 rightSide = player.transform.right;
                Debug.Log(rightSide);


                // Apply a force to simulate shifting the center of gravity to the right side
                constantForce.force = rightSide * forceMagnitude;

                // Apply torque to rotate the player
               // constantForce.torque = torque * forceMagnitude;
            }
        }
        if (player != null && Input.GetKeyDown(KeyCode.UpArrow)) // Check for Enter key press
        {
            if (constantForce != null)
            {
                // Determine the right side of the player
                Vector3 UpSide = player.transform.up;
                Debug.Log(UpSide);


                // Apply a force to simulate shifting the center of gravity to the right side
                constantForce.force = UpSide * forceMagnitude;

                // Apply torque to rotate the player
                // constantForce.torque = torque * forceMagnitude;
            }
        }
        if (player != null && Input.GetKeyDown(KeyCode.LeftArrow)) // Check for Enter key press
        {
            if (constantForce != null)
            {
                // Determine the right side of the player
                Vector3 UpSide = player.transform.right;
                Debug.Log(UpSide);


                // Apply a force to simulate shifting the center of gravity to the right side
                constantForce.force = -UpSide * forceMagnitude;

                // Apply torque to rotate the player
                // constantForce.torque = torque * forceMagnitude;
            }
        }
    }
}
