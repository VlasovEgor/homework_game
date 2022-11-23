using UnityEngine;

public class GetValuePhysicsData : MonoBehaviour
{
    [SerializeField] private Transform _objectTransform;
    [SerializeField] private Collider _objectCollider;
    [SerializeField] private Rigidbody _objectRigidbody;

    public Vector3 GetPosition
    {
        get { return _objectTransform.position; }
    }

    public Collider GetCollider
    {
        get { return _objectCollider; }
    }

    public Rigidbody GetRigidbody
    {
        get { return _objectRigidbody; }
    }
}
