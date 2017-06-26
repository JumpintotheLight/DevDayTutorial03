using UnityEngine;
using System.Collections;

public class ChangeGravity : MonoBehaviour
{

    public float gravity_scale;

    void Start()
    {
        Physics.gravity = new Vector3(0, gravity_scale, 0);
    }



    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * gravity_scale * 1000.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * gravity_scale * 1000.0f;

        //transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);

        Physics.gravity = new Vector3(x, -1.0f, z);
        Debug.Log("Physics.gravity.magnitude." + Physics.gravity.magnitude);
    }
}