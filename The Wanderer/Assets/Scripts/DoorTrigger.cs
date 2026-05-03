using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator doorLeftAnimator;


    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetTrigger("isOpen");
        doorLeftAnimator.SetTrigger("isOpen");

        doorAnimator.ResetTrigger("isClose");
        doorLeftAnimator.ResetTrigger("isClose");
    }


    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetTrigger("isClose");
        doorLeftAnimator.SetTrigger("isClose");

        doorAnimator.ResetTrigger("isOpen");
        doorLeftAnimator.ResetTrigger("isOpen");
    }
}
