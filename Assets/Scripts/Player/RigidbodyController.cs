using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyController : Movement
{
    Rigidbody rig;

    void OnEnable()
    {
        rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rig.AddForce((movementVector + gravityDirection*gravityStrength + jumpVector) * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}
