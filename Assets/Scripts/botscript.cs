using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botscript : MonoBehaviour
{
    public GameObject bot;
    public Rigidbody rb;
    public GameObject[] wheels;

    public float Botspeed = 10;
    public float BotRot = 1;
    public float WheelRot = 50;
    public float gravity = 0;

    public GameObject RGrip, LGrip;
    public GameObject ArmRot;
    public float GripSpeed = 2;
    public float ArmRotate = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WheelRot = Vector3.Magnitude(rb.velocity);
        //Debug.Log(WheelRot);
        //gravity;

        
        
            rb.AddForce(new Vector3(0, -1, 0) * (gravity));

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddRelativeForce(Vector3.forward * Botspeed);
                forwardwheels();


                if (Input.GetKey(KeyCode.D))
                {
                    rb.AddRelativeTorque(new Vector3(0, 1, 0) * BotRot);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    rb.AddRelativeTorque(new Vector3(0, -1, 0) * BotRot);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddRelativeForce(new Vector3(0, 0, -1) * Botspeed);

                if (Input.GetKey(KeyCode.D))
                {
                    rb.AddRelativeTorque(new Vector3(0, -1, 0) * BotRot);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    rb.AddRelativeTorque(new Vector3(0, 1, 0) * BotRot);
                }
            }
        
            
            if(Input.GetKey(KeyCode.Z))
        {

            if (RGrip.transform.localPosition.x > 0.1)
            {
                LGrip.transform.localPosition += new Vector3(1, 0, 0) * (Time.deltaTime*GripSpeed);
                RGrip.transform.localPosition += new Vector3(-1, 0, 0) * (Time.deltaTime*GripSpeed);
            }
        }

        if (Input.GetKey(KeyCode.X))
        {
            if (LGrip.transform.localPosition.x > -0.5)
            {
                LGrip.transform.localPosition += new Vector3(-1, 0, 0) * (Time.deltaTime*GripSpeed);
                RGrip.transform.localPosition += new Vector3(1, 0, 0) * (Time.deltaTime*GripSpeed);
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
                ArmRot.transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * ArmRotate, Space.Self);
            
        }

        if (Input.GetKey(KeyCode.E))
        { 
                ArmRot.transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * ArmRotate, Space.Self);
            
        }

        Debug.Log(ArmRot.transform.rotation.eulerAngles);

    }
    public void forwardwheels()
    {
        wheels[0].transform.Rotate(new Vector3(0, 1, 0)*WheelRot);
        wheels[1].transform.Rotate(new Vector3(0, 1, 0)*WheelRot);
        wheels[2].transform.Rotate(new Vector3(0, 1, 0)*WheelRot);
        wheels[3].transform.Rotate(new Vector3(0, 1, 0)*WheelRot);
    }

    
}
