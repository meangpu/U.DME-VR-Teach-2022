using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] GameObject _leftTeleportation;
    [SerializeField] GameObject _rightTeleportation;

    [SerializeField] InputActionProperty _leftTeleportBtn;
    [SerializeField] InputActionProperty _rightTeleportBtn;

    [SerializeField] InputActionProperty _leftGrabBtn;
    [SerializeField] InputActionProperty _rightGrabBtn;

    private void Update()
    {
        _leftTeleportation.SetActive(_leftGrabBtn.action.ReadValue<float>() == 0 && _leftTeleportBtn.action.ReadValue<float>() > 0.1f);
        _rightTeleportation.SetActive(_rightGrabBtn.action.ReadValue<float>() == 0 && _rightTeleportBtn.action.ReadValue<float>() > 0.1f);
    }

}
