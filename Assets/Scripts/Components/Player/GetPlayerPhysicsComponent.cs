using UnityEngine;

public class GetPlayerPhysicsComponent : MonoBehaviour, IGetPlayerPhysicsComponent
{
    [SerializeField] private GetValuePhysicsData _physicsData;
 
    public Collider GetPlayerCollider()
    {
        return _physicsData.GetCollider;
    }

    public Rigidbody GetPlayerRigidbody()
    {
        return _physicsData.GetRigidbody;
    }

    public Vector3 GetPlayerPosition()
    {
        return _physicsData.GetPosition;
    }
}
