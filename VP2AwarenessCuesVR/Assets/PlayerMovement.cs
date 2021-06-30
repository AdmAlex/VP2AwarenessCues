using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 7f;
    [SerializeField] private float _mouseSensitivity = 50f;
    [SerializeField] private float _minCameraview = -70f, _maxCameraview=80f;
    private CharacterController _charController;
    private Camera _camera;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
        _camera = Camera.main;
        
        if (_charController == null)
            Debug.Log("No Character Controller");

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical  + transform.right * horizontal;
        _charController.Move(movement * Time.deltaTime *_speed);


        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, _minCameraview, _maxCameraview);
        _camera.transform.localRotation = Quaternion.Euler(xRotation, 0,0);
        transform.Rotate(Vector3.up * mouseX * 3);
    }

}
