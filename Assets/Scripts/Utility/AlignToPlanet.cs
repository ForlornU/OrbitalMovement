using UnityEngine;

[ExecuteInEditMode]
public class AlignToPlanet : MonoBehaviour
{
    public Transform planet;
    public LayerMask planetOnly;

    Vector3 gravity;
    Vector3 surfacePoint;
    Vector3 surfaceNormal;

    void Update()
    {
        gravity = (planet.position - transform.position).normalized;

        RaycastToSurface();
        Align();
        StickToSurface();
    }

    void RaycastToSurface()
    {
        RaycastHit hit;
        Vector3 spacePosition = transform.position + -gravity * 50f;
        if (Physics.Raycast(spacePosition, gravity, out hit, Vector3.Distance(spacePosition, planet.position), planetOnly))
        {
            if (hit.transform != planet && hit.transform != null)
            {
                Debug.Log(hit.transform);
                return;
            }

            //Debug.DrawLine(spacePosition, hit.point, Color.yellow);
            //Debug.DrawLine(transform.position, hit.point, Color.red);

            surfacePoint = hit.point;
            surfaceNormal = hit.normal;
        }
    }

    void StickToSurface()
    {
        transform.position = surfacePoint;
    }

    void Align()
    {
        Quaternion rotationToPlanet = Quaternion.FromToRotation(transform.up, -gravity) * transform.rotation;
        Quaternion surfaceRotation = Quaternion.FromToRotation(transform.up, surfaceNormal) * transform.rotation;

        Quaternion halfwayRotation = Quaternion.Lerp(rotationToPlanet, surfaceRotation, 0.5f);
        transform.rotation = halfwayRotation;
    }
}
