using UnityEngine;

[ExecuteInEditMode]
public class AlignToPlanet : MonoBehaviour
{
    public Transform planet;
    public LayerMask planetOnlyMask;
    public float rayOffsetFromSurface = 50f;
    Vector3 gravity;

    RayData surfaceData = new RayData();

    public bool debug = false;

    void Update()
    {
        gravity = (planet.position - transform.position).normalized;

        if (RaycastToSurface())
        {
            AlignToSurface();
            StickToSurface();
            DebugRays();
        }
    }

    bool RaycastToSurface()
    {
        RaycastHit hit;
        Vector3 spacePosition = transform.position + -gravity * rayOffsetFromSurface;
        surfaceData.grounded = false;

        if (Physics.Raycast(spacePosition, gravity, out hit, Vector3.Distance(spacePosition, planet.position), planetOnlyMask))
        {
            surfaceData.grounded = true;
            surfaceData.point = hit.point;
            surfaceData.normal = hit.normal;
        }

        return surfaceData.grounded;
    }

    void DebugRays()
    {
        if (!debug)
            return;

        Debug.DrawLine(transform.position + -gravity * rayOffsetFromSurface, surfaceData.point, Color.yellow);
        Debug.DrawLine(transform.position, surfaceData.point, Color.red);

    }

    void StickToSurface()
    {
        transform.position = surfaceData.point;
    }

    void AlignToSurface()
    {
        Quaternion rotationToPlanet = Quaternion.FromToRotation(transform.up, -gravity) * transform.rotation;
        Quaternion surfaceRotation = Quaternion.FromToRotation(transform.up, surfaceData.normal) * transform.rotation;

        Quaternion halfwayRotation = Quaternion.Lerp(rotationToPlanet, surfaceRotation, 0.5f);
        transform.rotation = halfwayRotation;
    }
}
