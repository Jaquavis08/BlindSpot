using UnityEngine;
using UnityEngine.InputSystem;

public class interaction : MonoBehaviour
{
    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 0)
            return;

        Debug.Log("INTERACT NOW OR ELSE");

        Physics2D.BoxCast(transform.position, new Vector2(1.5f, 1.5f), 0, Vector2.zero);
    }
}
