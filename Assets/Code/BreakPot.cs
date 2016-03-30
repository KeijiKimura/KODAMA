using UnityEngine;
using System.Collections;

public class BreakPot : MonoBehaviour {


    public GameObject particles;
    public GameObject Pot;
    public Renderer potRend;


	// Use this for initialization
	void Start () {

        potRend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Floor")
        {
            potRend.enabled = false;
            print("breakPotWorking");
            particles.SetActive(true);
        }

    }
}
