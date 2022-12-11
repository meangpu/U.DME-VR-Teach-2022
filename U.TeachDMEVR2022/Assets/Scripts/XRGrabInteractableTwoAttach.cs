using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    [SerializeField] Transform _leftAttachTransform;
    [SerializeField] Transform _rightAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = _leftAttachTransform;
        }
        else if (args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = _rightAttachTransform;
        }

        base.OnSelectEntered(args);
    }
}
