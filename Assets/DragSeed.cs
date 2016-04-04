using UnityEngine;
using System.Collections;

public class DragSeed : MonoBehaviour
{

    public GameObject LilPlant;
    public Rigidbody rb;
    float distance = 20;

    // Use this for initialization

        void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        rb.isKinematic = false;
        rb.detectCollisions = true;
        transform.position = objPosition;
      

    }

    // Update is called once per frame
    void Update()
    {

    }
}