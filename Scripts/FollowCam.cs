using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public float xOffset = 1f;
    public Transform target;

    public Vector2 minBounds;
    public Vector2 maxBounds;

    // Update is called once per frame
    void Update()
    {
        //this is for checking if the target i.e. character is still there or not
        if(target != null){
        Vector3 newyPos = new Vector3(transform.position.x, target.position.y + yOffset, -10f);
        Vector3 newxPos = new Vector3(target.position.x + xOffset, transform.position.y, -10f);

        // Check if the character is within the specified bounds
        if (IsWithinBounds(newxPos))
            transform.position = Vector3.Slerp(transform.position, newxPos, FollowSpeed * Time.deltaTime);

        if (IsWithinBounds(newyPos))
            transform.position = Vector3.Slerp(transform.position, newyPos, FollowSpeed * Time.deltaTime);
    }
}

    // Check if a position is within the specified bounds
    private bool IsWithinBounds(Vector3 position)
    {
        return position.x >= minBounds.x && position.x <= maxBounds.x
            && position.y >= minBounds.y && position.y <= maxBounds.y;
    }
}
