using System;
using UnityEngine;

public class VectorBehaviour : MonoBehaviour
{
    public event Action<Vector3> OnValueChanged;

    [SerializeField] private Vector3 _value;

    public Vector3 Value
    {
        get { return _value; }
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }
}
