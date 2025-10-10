using UnityEngine;
using UnityEngine.InputSystem;

public class interaction : MonoBehaviour
{
    public Vector2 size;
    public LayerMask mask;
    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        RaycastHit2D hit = Physics2D.BoxCast(transform.position, size, 0, Vector2.zero, 0, mask);

        Debug.Log("any message here");

        if (hit && hit.collider.TryGetComponent(out interactable Interactable))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, size);
    }
}
