using UnityEngine;
using System.Collections;

public class MouseDrage : MonoBehaviour {


    public Rigidbody rb;
    public GameObject Waterfall;
    float distance = 30;

	// Use this for initialization
	void OnMouseDrag () {

        print("working");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        rb.isKinematic = false;
        rb.detectCollisions = true;
        transform.position = objPosition;
        Waterfall.SetActive(true);
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
