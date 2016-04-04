using UnityEngine;
using System.Collections;

public class ScrollingCamera : MonoBehaviour
{

 
    public Transform to;
    public Transform from;
    public float percentage = 0f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.mousePosition.y > Screen.height - 50)
        {
            percentage -= Time.deltaTime / 15f;

            transform.position = Vector3.Lerp(from.position, to.position, percentage);
        }
     
        if (Input.mousePosition.y < 100)
        {
            percentage += Time.deltaTime / 15f;

            transform.position = Vector3.Lerp(from.position, to.position, percentage);
        }

    }
    
}
