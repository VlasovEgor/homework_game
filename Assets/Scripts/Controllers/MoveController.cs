using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Entity _unit;
    private IMovingComponent _movingComponent;

    private void Awake()
    {
        _movingComponent = _unit.Get<IMovingComponent>();
    }

    private void FixedUpdate()
    {
        HandleKeyvoard();
    }

    private void HandleKeyvoard()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Move(inputVector);
    }

    public void Move(Vector3 inputVector)
    {
        _movingComponent.Movement(inputVector);
    }
}
