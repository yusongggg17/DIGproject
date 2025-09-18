using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [SerializeField] private GameObject teacher;
    [SerializeField] private float reappearInterval = 1f;
    private float timer;
    private Vector3 offset = new Vector3(2f,0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > reappearInterval) {
            Vector3 offsetWorld = teacher.transform.right * offset.x + teacher.transform.up * offset.y;
            transform.position = teacher.transform.position  + offsetWorld;
            timer = 0f;
        }
        //Vector3 direction = (teacher.position - transform.position).normalized;
        Vector3 movement = Vector3.down * 15f * Time.deltaTime;
        transform.Translate(movement);
    }
}
