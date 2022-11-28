using System;
using UnityEngine;

public class TriggerComponent : MonoBehaviour,ITriggerComponent
{
    public event Action<Collider> PlayerTriggerEntered;

    [SerializeField] private PlayerTrigger _playerTrigger;

    private void OnEnable()
    {
        _playerTrigger.PlayerTriggerEntered += OnTriggerEntered;
    }

    private void OnDisable()
    {
        _playerTrigger.PlayerTriggerEntered -= OnTriggerEntered;
    }

    public void OnTriggerEntered(Collider obj)
    {
        PlayerTriggerEntered?.Invoke(obj);
    }
}
