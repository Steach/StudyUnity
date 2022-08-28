using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public float camRotation;

    //float camSens = 0.25f; //How sensitive it with mouse
    //private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        //transform.RotateAround(player.transform.position, Vector3.up, 50 * Time.deltaTime);
        //transform.rotation = player.rotation;
        //lastMouse = Input.mousePosition - lastMouse ;
        //lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0 );
        //lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x , transform.eulerAngles.y + lastMouse.y, 0);
        //transform.eulerAngles = lastMouse;
        //lastMouse = Input.mousePosition;        
    }
}