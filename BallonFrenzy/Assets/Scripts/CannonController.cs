using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    // Code for cannon controller
    // Reference: https://www.youtube.com/watch?v=RnEO3MRPr5Y&list=LL&index=2


    // Variables
    public float rotationSpeed = 1; // Speed where player can turn the cannon left/right/up/down
    public float shootPower = 5; // Speed cannonball the cannon shoots out

    // Drag in objects from hierachy into script
    public GameObject CannonBall;
    public Transform ShotPoint;

    // Update is called once per frame
    private void Update()
    {
        // Reads input from a and d keys
        // and w and s keys
        float HorizontalRotation = Input.GetAxis("Mouse X");
        float VerticalRotation = Input.GetAxis("Mouse Y");

        // Current rotation rotates on its y axis not x axis
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles +
            new Vector3(0, HorizontalRotation * rotationSpeed, VerticalRotation * -rotationSpeed));

        // Shoot cannonball
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // When the cannonball is created it will set its velocity
            // that is outwards from the cannon
            GameObject CreatedCannonBall = Instantiate(CannonBall, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonBall.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * shootPower;
        }
    }
}
