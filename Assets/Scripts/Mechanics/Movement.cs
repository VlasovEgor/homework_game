using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private VectorBehaviour _offset;
    [SerializeField] private EventReceiver _movingReceiver;
    [SerializeField] private Rigidbody _rigidbody;


    private void OnEnable()
    {
        _movingReceiver.OnEvent += OnMoving;
    }

    private void OnDisable()
    {
        _movingReceiver.OnEvent -= OnMoving;
    }

    private void OnMoving()
    {
        _rigidbody.velocity = new Vector3(_offset.Value.x, 0, _offset.Value.z);
    }
}
