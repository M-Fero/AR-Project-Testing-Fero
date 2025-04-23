using UnityEngine;

public class Character : ARInteractableObject
{
    [SerializeField] private Renderer renderer;
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
                if(renderer == null) return;
                renderer.materials[0].EnableKeyword("_EMISSION");
                renderer.materials[0].SetColor("_EmissionColor", new Color(0.5f, 0.5f,0.5f,0.1f));
            case State.Active:
                animator.SetTrigger("StartInteraction");
                if (renderer == null) return;
                renderer.materials[0].EnableKeyword("_EMISSION");
                renderer.materials[0].SetColor("_EmissionColor", new Color(0, 0, 0, 0));
                break;
        }
    }
}
