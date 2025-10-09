using UnityEngine;

public class Rotate_2 : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 50f;
    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

