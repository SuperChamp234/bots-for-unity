using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmScript : MonoBehaviour
{

    [SerializeField] private Transform Joint1;
    [SerializeField] private Transform Joint2;
    [SerializeField] private Transform Joint3;
    [SerializeField] private Transform FingerLeft;
    [SerializeField] private Transform FingerRight;
    [SerializeField] private Transform GripSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Joint1.rotation = Quaternion.Euler(0, 0, 45);
        Joint2.rotation = Quaternion.Euler(0, 0, 135);
        Joint3.rotation = Quaternion.Euler(0, -90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if the j key is pressed, lower the joint by 5 degrees
        if (Input.GetKeyDown(KeyCode.J))
        {
            Joint1.Rotate(0, 0, 5);
            Joint2.Rotate(0, 0, 10);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Joint1.Rotate(0, 0, -5);
            Joint2.Rotate(0, 0, -10);
        }
        if(Input.GetKey(KeyCode.Z))
        {

            if (FingerLeft.transform.localPosition.x > 0.1)
            {
                FingerLeft.transform.localPosition += new Vector3(1, 0, 0) * Time.deltaTime;
                FingerRight.transform.localPosition += new Vector3(-1, 0, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (FingerLeft.transform.localPosition.x > -0.5)
            {
                FingerLeft.transform.localPosition += new Vector3(-1, 0, 0) * Time.deltaTime;
                FingerRight.transform.localPosition += new Vector3(1, 0, 0) * Time.deltaTime;
            }
        }
    }
}
