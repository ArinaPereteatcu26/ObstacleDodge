using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 6f;
    public float acceleration = 10f;
    public float rotationSpeed = 10f;

    private Vector3 currentVelocity = Vector3.zero;

    void Update()
    {
        SmoothMove();
    }

    private void SmoothMove()
    {
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.W)) v = 1f;
        if (Input.GetKey(KeyCode.S)) v = -1f;
        if (Input.GetKey(KeyCode.A)) h = -1f;
        if (Input.GetKey(KeyCode.D)) h = 1f;

        Vector3 targetDirection = new Vector3(h, 0, v).normalized;

        currentVelocity = Vector3.Lerp(currentVelocity, targetDirection * speed, Time.deltaTime * acceleration);

        transform.Translate(currentVelocity * Time.deltaTime, Space.World);

        if (targetDirection != Vector3.zero)
        {
            Quaternion targetRot = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
        }
    }
}
