using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "scriptable object /MoveData")]
public class MoveData : ScriptableObject
{
    public float moveSpeed = 5f;
    public float surfaceRotationSpeed = 2f;

    public float groundColSize = 0.55f;
    
    [Range(0f, 1f)]
    public float surfaceGravity = 1f;
    [Range(0f, 1f)]
    public float stickToSurface = 0.5f;
    
    public float jumpForce = 5f;
    public float jumpDuration = 0.4f;
}
