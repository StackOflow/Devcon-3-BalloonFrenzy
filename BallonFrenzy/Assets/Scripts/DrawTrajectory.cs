using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DrawTrajectory : MonoBehaviour
{
    // Code for trajectory | B.C
    // Variables
    CannonController cannonController; // get instance of cannon controller
    LineRenderer lineRenderer; // declare line renderer

    // # of points on the line
    public int numPoints = 50;

    // Distances between points
    public float distantPoints = 0.1f;

    // Physic layers
    // when the line collides w/ a surface it shouldnt go through
    public LayerMask CollidedLayers;

    // Start is called before the first frame update
    void Start()
    {
        cannonController = GetComponent<CannonController>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Line renderer can take in as many points
        lineRenderer.positionCount = (int)numPoints;
        List<Vector3> points = new List<Vector3>(); // declare empty list
        // Get cannonballs starting pos.
        Vector3 startingPosition = cannonController.ShotPoint.position;
        Vector3 startingVelocity = cannonController.ShotPoint.up * cannonController.shootPower;

        // Draw the trajectory line
        for (float t = 0; t < numPoints; t += distantPoints)
        {
            // handles the x & z components of the new point
            // the horizontal velocity of an object is constant as it moves through
            // the air / the y velocity changes next
            Vector3 newPoint = startingPosition + t * startingVelocity;
            newPoint.y = startingPosition.y + startingVelocity.y * t + Physics.gravity.y / 2f * t * t;
            points.Add(newPoint);

            // physics draws a spheres at the point requested at a certain radius
            // states a list of objects that the sphere collides with
            // draw a sphere at the point requested
            if (Physics.OverlapSphere(newPoint, 0.07f, CollidedLayers).Length > 0)
            {
                lineRenderer.positionCount = points.Count;
                break;
            }

        }

        lineRenderer.SetPositions(points.ToArray());
    }
}
