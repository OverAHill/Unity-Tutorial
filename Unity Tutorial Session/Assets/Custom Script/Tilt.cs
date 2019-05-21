using UnityEngine;
using System.Collections;

public class Tilt : MonoBehaviour
{
    public float smooth = 1.5f;
    public float maxTiltAngle = 30.0f;

    // Update is called once per frame
    void Update()
    {
        // check if the user is pressing left or right, up or down on the keyboard
        // by default Unity assigns the "a" and "d" key & the left and right arrow keys to the
        // horizontal axis and the "w" and "s" key & the up and down arrows keys to the vertical axis.
        float tiltAroundX = Input.GetAxis("Horizontal") * maxTiltAngle;
        float tiltAroundZ = Input.GetAxis("Vertical") * maxTiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}

