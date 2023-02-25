using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Movement : MonoBehaviour
{
    #region --
    PlayerInputActions _inputActions;

    [SerializeField]
    protected MoveData moveData;

    public Transform planet;
    [SerializeField]
    Transform transformBody;

    protected Vector3 movementVector;
    protected Vector3 gravityDirection;
    protected float gravityStrength = 1f;
    protected Vector3 jumpVector;
    
    [SerializeField]
    LayerMask GroundLayerMask;
    [SerializeField]
    Transform groundCollider;

    RayData groundData;
    #endregion

    void Start()
    {
        groundData = new RayData();

        _inputActions = new PlayerInputActions();
        _inputActions.Enable();
        _inputActions.PlayerActionmap.Jump.performed += Jump;
    }
    
    void Update()
    {
        ApplyGravity();
        CheckGround();
        RotateToSurface();
        Move();
    }

    void ApplyGravity()
    {
        gravityDirection = (planet.position - transform.position).normalized;

        if (!groundData.grounded)
            gravityStrength += planet.GetComponent<Planet>().GravitationalPull * Time.deltaTime;
        else
            gravityStrength = moveData.surfaceGravity;
    }

    void RotateToSurface()
    {
        Quaternion gravityRotation = Quaternion.FromToRotation(transform.up, -gravityDirection) * transform.rotation;
        Quaternion surfaceRotation = Quaternion.FromToRotation(transform.up, groundData.normal) * transform.rotation;
        Quaternion finalRotation = Quaternion.Lerp(gravityRotation, surfaceRotation, moveData.stickToSurface);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, finalRotation, moveData.surfaceRotationSpeed * Time.deltaTime);
    }

    void Jump(InputAction.CallbackContext context)
    {
        if(groundData.grounded)
            StartCoroutine(ApplyJump());
    }
    
    IEnumerator ApplyJump()
    {
        gravityStrength = 0f;
        jumpVector = Vector3.zero;

        float force = moveData.jumpForce;
        float t = 0f;

        while(t < moveData.jumpDuration)
        {
            jumpVector = -gravityDirection * force;
            force = Mathf.Lerp(moveData.jumpForce, 0f, t / moveData.jumpDuration);
            t += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }

        jumpVector = Vector3.zero;
    }
    
    void Move()
    {
        Vector2 input = _inputActions.PlayerActionmap.Movement.ReadValue<Vector2>();

        if (groundData.grounded)
            movementVector = (transformBody.forward * input.y + transformBody.right * input.x) * moveData.moveSpeed;
    }
    
    void CheckGround()
    {        
       if(Physics.CheckSphere(groundCollider.position, moveData.groundColSize, GroundLayerMask))
        {
            Physics.Raycast(groundCollider.position, -transform.up, out RaycastHit hit, 5f);
            groundData.grounded = true;
            groundData.normal = hit.normal;
            return;
        }

        groundData.grounded = false;
        groundData.normal = -gravityDirection;
    }
}
