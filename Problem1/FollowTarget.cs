using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // SerializedField is used to allow modifications in the editor while maintaining the field private
    [SerializeField] private Vector3 target;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float stopDistance = 1f;// added as a field to allow changes
    
    void Update()
    {
        Vector3 distanceVector = target - transform.position; // calculate distance
        float distanceSquared = distanceVector.sqrMagnitude; // use square magnitude to avoid root calculations
        
        if (distanceSquared > stopDistance * stopDistance) // squaring the intended stop distance for comparison
        {
            transform.position += distanceVector.normalized * (speed * Time.deltaTime); // multiply with deltaTime to make it framerate independent and achieve constant movement
        }
    }
}