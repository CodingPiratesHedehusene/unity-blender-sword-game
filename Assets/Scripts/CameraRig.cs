using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public Camera Camera;
    public Transform Following;
    public float Speed = 10f;
    
    Vector3 Rotation = new Vector3(0, 0, 0);

    void Update()
    {
        // make sure camera always looks at player
        Camera.transform.LookAt(Following);
        
        // keep distance to player
        transform.position = Vector3.MoveTowards(
            transform.position,
            Following.transform.position,
            Speed * Time.deltaTime);
        
        // rotate the camera rig around player
        Rotation.y += Input.GetAxis("Mouse X");
        Rotation.x -= Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(Rotation);
    }
}
