using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpPower = 7f;

    float Rotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation
        if (Input.GetKey(KeyCode.A))
        {
            // 60 degrees per second
            Rotation = Rotation - 60 * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Rotation = Rotation + 60 * Time.deltaTime;
        }
        
        transform.rotation = Quaternion.Euler(0, Rotation, 0);
        
        // Position
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(
                Vector3.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(
                Vector3.back * Speed * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            var rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
        }
    }
}
