using UnityEngine;

public interface IGetPlayerPhysicsComponent 
{
    Rigidbody GetPlayerRigidbody();
    Collider GetPlayerCollider();

    Vector3 GetPlayerPosition();
}
