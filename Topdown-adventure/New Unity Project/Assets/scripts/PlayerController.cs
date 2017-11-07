using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    float M_speed = 4f;

    Vector3 Forward, Right;

    Rigidbody rb;

	void Start () {
        Forward = Camera.main.transform.forward;
        Forward.y = 0;
        Forward = Vector3.Normalize(Forward);
        Right = Quaternion.Euler(new Vector3(0, 90, 0)) * Forward;
	}

   
    void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }

    }


    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorKey"), 0, Input.GetAxis("VerKey"));
        Vector3 rightMov = Right * M_speed * Time.deltaTime * Input.GetAxis("HorKey");
        Vector3 upMov = Forward * M_speed * Time.deltaTime * Input.GetAxis("VerKey");

        Vector3 heading = Vector3.Normalize(rightMov + upMov);
        transform.forward = heading;
        transform.position += rightMov;
        transform.position += upMov;

    }

  

}
