using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Metadata;

public class IKSolver : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    //public Transform Target;
    public GameObject Parent;
    public GameObject Target;
    public Transform Shoulder;
    // Set min and max angles for each bone 

    List<Vector3> effectorPositions = new List<Vector3>();

    // Vector of child objects
    List<Vector3> rotationProperties = new List<Vector3>();



    public void Start()
    {
        // Get all childs of the object
        Transform[] objectChildren = GetComponentsInChildren<Transform>();

        // Loop through each child and store their rotation properties
        foreach (Transform child in objectChildren)
        {
            // Store each child's rotation properties into the list
            rotationProperties.Add(child.rotation.eulerAngles);
        }
        // Loop through each child and store their position properties
        foreach (Transform child in objectChildren)
        {
            // Store each child's position properties into the list
            effectorPositions.Add(child.transform.position);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Get all childs of the object
        Transform[] objectChildren = GetComponentsInChildren<Transform>();

        Vector3 targetPosition = Target.transform.position;


        /*
    
        // Loop through each child and rotate 10 degrees per second on the Y axis
        foreach (Transform child in objectChildren)
        {

            child.Rotate(Vector3.left * Time.deltaTime * 10);
            Debug.Log($"{child.name} position is: {child.transform.position} and the rotation is {Vector3.left}");

        }

        */
    }

    // Function to calculate the angles of each effector using Inverse Kinematics
    public void CalculateAngles(Vector3[] effectorPositions, Vector3 targetPosition)
    {
        // Get the distances between each effector and the target
        Vector3[] distances = new Vector3[effectorPositions.Length];

        for (int i = 0; i < effectorPositions.Length; i++)
        {
            distances[i] = targetPosition - effectorPositions[i];
        }
        
        // Calculate the angles for each effector using the distances
        for (int i = 0; i < effectorPositions.Length; i++)
        {
            // Calculate the angle of the current effector
            float angle = Mathf.Atan2(distances[i].y, distances[i].x) * Mathf.Rad2Deg;

            // Clamp the angle so it stays within the limits
            angle = Mathf.Clamp(angle, -90f, 90f);

            // Set the angle of the current effector
            effectorPositions[i].z = angle;

            Debug.Log("effectorPositions[" + i + "].z = " + effectorPositions[i].z);
        }

    }
}
