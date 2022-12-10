using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class FireOnActivate : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _bulletSpawnPoint;
    [SerializeField] float _bulletSpeed;
    [SerializeField] float _destroyBulletAfterSecond;

    void Start()
    {
        XRGrabInteractable grabAbleScpt = GetComponent<XRGrabInteractable>();
        grabAbleScpt.activated.AddListener(FireBullet);
    }

    void FireBullet(ActivateEventArgs arg)
    {
        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.position = _bulletSpawnPoint.position;
        newBullet.GetComponent<Rigidbody>().velocity = _bulletSpawnPoint.forward * _bulletSpeed;
        Destroy(newBullet, _destroyBulletAfterSecond);

    }
}
