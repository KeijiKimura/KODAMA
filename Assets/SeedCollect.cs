using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SeedCollect : MonoBehaviour
{

    public GameObject Plant;
    public GameObject Kodama;
    public bool AllSeeds;
    private float SeedCount;
 
    // Use this for initialization
    void Start()
    {
        SeedCount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SeedCount == 5f)
        {
            AllSeeds = true;
            
        }

        if (AllSeeds)
        {
            GrowPlant();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Seed")
        {
            print("SeedCollected!");
            SeedCount++;
            Destroy(other.gameObject);
            
          

        }

    }
 

    void GrowPlant()
    {
        Plant.SetActive(true);
        Kodama.SetActive(true);
    }
}
