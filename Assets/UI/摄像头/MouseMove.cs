using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{

    [SerializeField]
    private GameObject center;

    private Camera cameraObj;
    public float dragSpeed = 10f;

    void Awake()
    {
        cameraObj = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.GetAxis("Mouse X"));
            Debug.Log(Input.GetAxis("Mouse Y"));
            cameraObj.transform.RotateAround(center.transform.position,
                                            cameraObj.transform.up,
                                            Input.GetAxis("Mouse X") * dragSpeed);

            cameraObj.transform.RotateAround(center.transform.position,
                                            cameraObj.transform.right,
                                            -Input.GetAxis("Mouse Y") * dragSpeed);
        }

    }
}
