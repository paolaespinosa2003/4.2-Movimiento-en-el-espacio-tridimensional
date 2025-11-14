
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -8);
    void LateUpdate()
    {
        if (target == null) return;
        Vector3 newPos = new Vector3(target.position.x + offset.x, transform.position.y, target.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 8f);
    }
}
