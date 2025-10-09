using UnityEngine;

public class FOV : MonoBehaviour
{
    public float fovAngle = 90f;
    public Transform fovPoint;
    public float range = 8;

    public Transform target;

    private void Update()
    {
        Vector2 dir = transform.position - transform.position;
        float angel = Vector3.Angle(dir, fovPoint.up);
        RaycastHit2D r = Physics2D.Raycast(fovPoint.position, dir, range);

        if (angel < fovAngle / 2)
        {
            if (r.collider.CompareTag("Player"))
            {
                //Player Spotted
                print("Spotted");
                Debug.DrawRay(fovPoint.position, dir, Color.red);
            }
            else
            {
                print("Not there");
            }
        }
    }
}
