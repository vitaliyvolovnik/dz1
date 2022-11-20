using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]private float speed=1;
    private float _horizontalInput;
    private float _verticalInput;


    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        transform.Translate(_horizontalInput* speed, 0, _verticalInput * speed);
    }
}
