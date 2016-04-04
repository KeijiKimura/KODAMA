using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {


    public Transform from;
    public Transform to;

    public Transform fromCave;
    public Transform toTree;
    public float percentage = 0f;

    static public bool FirstLerp;
    static public bool SecondLerp;

	// Use this for initialization
	void Start () {
        SecondLerp = true;
	}
	
	// Update is called once per frame
	void Update () {


        if (FirstLerp)
        {
            percentage += Time.deltaTime / 30f;

            transform.position = Vector3.Lerp(from.position, to.position, percentage);
        }

        if (SecondLerp)
        {
            percentage += Time.deltaTime / 30f;

            transform.position = Vector3.Lerp(fromCave.position, toTree.position, percentage);

        }
       
    }

    
}
