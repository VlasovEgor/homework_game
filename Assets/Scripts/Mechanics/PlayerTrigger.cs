using System;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public event Action<Collider> PlayerTriggerEntered;

    [SerializeField] private EventReceiver_Trigger _triggerReciver;

    private void OnEnable()
    {
        _triggerReciver.OnTriggerEntered += OnTriggerEntered;
    }

    private void OnDisable()
    {
        _triggerReciver.OnTriggerEntered -= OnTriggerEntered;
    }

    private void OnTriggerEntered(Collider obj)
    {
        PlayerTriggerEntered?.Invoke(obj);
    }
}
