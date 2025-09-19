using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using System.Collections;
using UnityEditor;

public class TeacherRotation : MonoBehaviour
{
    public GameObject teacher;
    public GameObject student;
    private Vector3 lastStudentPos;
    private bool isPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastStudentPos = student.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            transform.RotateAround(teacher.transform.position, Vector3.up, 90 * Time.deltaTime);
            float yRotation = transform.eulerAngles.y;
            if (Mathf.Abs(yRotation - 180f) < 0.3f)
            {
                Vector3 delta = student.transform.position - lastStudentPos;
                bool isMoving = delta.magnitude > 0.01f;
                //lastStudentPos = student.transform.position;
                if (isMoving)
                {
                    Debug.Log("is moving");
                    EditorApplication.ExitPlaymode();
                }
                else
                {
                    StartCoroutine(PauseRotation());
                }
            }
            lastStudentPos = student.transform.position;

        }
    }
    private IEnumerator PauseRotation()
    {
        isPaused = true;
        yield return new WaitForSeconds(2f);
        isPaused = false;
    }
}

