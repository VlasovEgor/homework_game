using System;
using UnityEngine;

public interface ITriggerComponent
{
    public event Action<Collider> PlayerTriggerEntered;

    public void OnTriggerEntered(Collider obj);
}