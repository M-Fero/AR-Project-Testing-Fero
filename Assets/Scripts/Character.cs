using UnityEngine;

public class Character : ARInteractableObject
{
    private Animator animator;  
    private void OnEnable()
    {
        animator = GetComponent<Animator>();
    }
    protected override void SetState(State state)
    {
        base.SetState(state);
        switch (state)
        {
            case State.Idle:
                animator.SetTrigger("GoToIdle");
                break;
            case State.Active:
                animator.SetTrigger("StartInteraction");
                break;
        }
    }
}
