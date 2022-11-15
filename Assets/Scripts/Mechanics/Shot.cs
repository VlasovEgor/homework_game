using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private EventReceiver _shotReceiver;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private TimerBehaviour _countdown;
    [SerializeField] private Transform _placeShot;
    [SerializeField] private IntBehaviour _bulletSpeed;

    private void OnEnable()
    {
        _shotReceiver.OnEvent += Shoot;
    }

    private void OnDisable()
    {
        _shotReceiver.OnEvent -= Shoot;
    }

    private void Shoot()
    {
        if (_countdown.IsPlaying)
        {
            return;
        }

       GameObject newBullet= Instantiate(_bulletPrefab, _placeShot.position, Quaternion.identity);
       newBullet.GetComponent<Rigidbody>().AddForce(Vector3.back * _bulletSpeed.Value, ForceMode.Impulse);

        _countdown.ResetTime();
        _countdown.Play();
    }
}