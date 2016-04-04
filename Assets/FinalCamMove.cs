using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
public class FinalCamMove : MonoBehaviour {


    public Transform camFrom;
    public Transform camTo;
    public float percentage = 0f;

    public ScrollingCamera scrollCam;

    static public bool kodamaBorn;

	// Use this for initialization
	void Start () {

        scrollCam = GetComponent<ScrollingCamera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (kodamaBorn)
        {
            scrollCam.enabled = false;
            moveCam();
           GetComponent<Bloom>().bloomThreshold = .3f;
        }
        
    }

    void moveCam()
    {
        percentage += Time.deltaTime / 5f;
        transform.position = Vector3.Lerp(camFrom.position, camTo.position, percentage);
    }
}
