using UnityEngine;
using System.Collections;

public class MovePlant : MonoBehaviour {


    public Transform plantFrom;
    public Transform plantTo;
    public float percentage = 0f;
  


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        percentage += Time.deltaTime / 5f;

        transform.position = Vector3.Lerp(plantFrom.position, plantTo.position, percentage);
        
    }
}
