using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public Transform VectorBack;
    public Transform VectorForward;
    public Transform VectorRight;
    public Transform VectorLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, VectorLeft.position.x, VectorRight.position.x);
        viewPos.z = Mathf.Clamp(viewPos.z, VectorBack.position.z, VectorForward.position.z);
        transform.position = viewPos;
    }
}
