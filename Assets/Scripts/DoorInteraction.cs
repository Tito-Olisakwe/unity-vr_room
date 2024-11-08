using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorInteraction : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            animator.SetBool("isOpen", true);
        }
    }
}
