using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Entity _unit;
    private IShotComponent _shotComponent;

    private void Awake()
    {
        _shotComponent = _unit.Get<IShotComponent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shotComponent.Shoot();
        }
    }
}
