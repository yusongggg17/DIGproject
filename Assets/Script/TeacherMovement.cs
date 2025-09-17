using UnityEngine;

public class TeacherMovement: MonoBehaviour
{
    public float moveSpeed = 10f; 
    private Vector3 moveDirection = Vector3.zero;
    public int direction = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.right * direction * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls")) {
            direction = -direction;
        }
    }
}
