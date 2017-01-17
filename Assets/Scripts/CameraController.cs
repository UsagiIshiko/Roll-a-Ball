using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;   // Player GameObject Container

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;    // Calculate the camera's position using the difference between the camera and player at start.
    }

    // Update is called once per frame
    void Update()
    {
    }

    // For Follow Cameras, Procedural Animation andgathering last known states
    // Runs every frame like Update, but runs after all items in Update guaranteed.
    // This is good in this code as it sets the position of the camera after the player has moved.
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;    // Maintain the offset as the Camera's position
    }
}
