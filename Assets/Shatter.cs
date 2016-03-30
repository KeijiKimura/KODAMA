using UnityEngine;
using System.Collections;

public class Shatter : MonoBehaviour
{
    public GameObject Fragments;
    public GameObject Pot;
   
    // Use this for initialization
    void Start()
    {

        //Particles.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider coll)
    {

        GameObject Clone;

        if (coll.gameObject.tag == "Floor")
        {

            Clone = (Instantiate(Fragments, transform.position, transform.rotation)) as GameObject;
            
            //Particles.SetActive (true);
            this.gameObject.SetActive(false);

        }
      /*  if (coll.gameObject.tag == "Icicle")
        {

            Clone = (Instantiate(Littlebergs, transform.position, transform.rotation)) as GameObject;
            Clone = (Instantiate(Particles, transform.position, transform.rotation)) as GameObject;
            //Particles.SetActive (true);
            Bigberg.SetActive(false);

        }*/

        Debug.Log("pot shattered!");
    }

}

