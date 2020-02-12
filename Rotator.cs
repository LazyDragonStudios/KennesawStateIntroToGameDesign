using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//jade ainsworth
public class Rotator : MonoBehaviour
{
    public float leftlimit, rightlimit, forlimit, backlimit;
    public float speed;
    public float rotx;
    public float roty;
    public float rotz;
    private Vector3 vel;
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.GetComponent<Transform>();
        vel = new Vector3(.5f, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        t.position += speed * vel * Time.deltaTime;
        transform.Rotate(new Vector3(rotx, roty, rotz) * Time.deltaTime);

        if (t.position.x > rightlimit || t.position.x < leftlimit)
            vel.x *= -1;

        if (t.position.z > forlimit || t.position.z < backlimit)

            vel.z *= -1;
    }

}