using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Cam;
    public GameObject VectorBack;
    public GameObject VectorForward;
    private Rigidbody rb;
    private Touch touch;

    [Range(20,40)]
    public int speedModifier;
    public int forwardSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Variables.firstTouch == 1)
        {
            transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            Cam.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            VectorForward.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            VectorBack.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
        }





        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Variables.firstTouch = 1;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                rb.velocity = new Vector3(touch.deltaPosition.x * speedModifier * Time.deltaTime,
                                        transform.position.y,
                                        touch.deltaPosition.y * speedModifier * Time.deltaTime);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
