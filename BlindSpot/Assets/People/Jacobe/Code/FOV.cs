using Unity.VisualScripting;
using UnityEngine;

public class FOV : MonoBehaviour
{
    public float fovAngle = 5f;
    public Transform fovPoint;
    public float range = 8;
    public LayerMask layer;

    public Transform target;

    private void Update()
    {
        Vector2 old = target.position - transform.position;
        Vector2 dir = (new Vector2(old.y, -old.x)).normalized;
        float angel = Vector3.Dot(dir, fovPoint.up);
        RaycastHit2D r = Physics2D.Raycast(fovPoint.position, old.normalized, range, layer);

        //Debug.DrawRay(fovPoint.position, dir, Color.blue);

        if (angel > fovAngle)
        {
            if (r.collider && r.collider.CompareTag("Playera"))
            {
                //Player Spotted
                print("Spotted");
               
            }
            else
            {
                print("Not there");
            }
            
        }
    }

    private void OnDrawGizmos()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        Gizmos.DrawLine(fovPoint.position, fovPoint.position + dir * range);
    }
}
