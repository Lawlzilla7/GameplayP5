using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderbox : MonoBehaviour {

    [SerializeField]
    GameObject Door;

    [SerializeField]
    bool Isactive = false;

    [SerializeField]
    bool IsDoor = false;

    

    [SerializeField]
    float speed;

    [SerializeField]
    float Angle;

    [SerializeField]
    float AngleBack;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		

       

        if (Isactive == true)
        {
            //Door.transform.rotation = Quaternion.Lerp(From.rotation, To.rotation, Time.time * speed);
            Door.transform.rotation = Quaternion.AngleAxis(Angle, Vector3.up);
        }
        else
        {
            Door.transform.rotation = Quaternion.AngleAxis(AngleBack, Vector3.up);
        }

	}

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "krat")
        {
            Isactive = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "krat")
        {
            Isactive = false;
        }
    }


}
