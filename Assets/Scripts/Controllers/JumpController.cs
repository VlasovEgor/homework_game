using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] private Entity _unit;
    private IJumpComponent _jumpComponent;

    private void Awake()
    {
        _jumpComponent = _unit.Get<IJumpComponent>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpComponent.Jump();
        }
    }
}
