using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    
    [SerializeField]
    private float mouseSensitivity;

    private Vector2 mouse;
    private float xRotation;


    void Start()
    {
        xRotation = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        mouse *= Time.deltaTime * mouseSensitivity;

        xRotation -= mouse.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //playerBodyRigid.rotation.eulerAngles. = Quaternion.Euler(xRotation, 0f, 0f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.transform.Rotate(Vector3.up * mouse.x);
    }
}
