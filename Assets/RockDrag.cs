using UnityEngine;
using System.Collections;

public class RockDrag : MonoBehaviour
{
    public GameObject Water;
    public GameObject Seeds;
    public GameObject WiltedSeeds;

    static public bool RockTriggered;
    public Rigidbody rb;
    public GameObject Waterfall;
    float distance = 30;
    float rockCount;


    void Start()
    {
        rockCount = 0;
    }

    // Use this for initialization
    void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        rb.isKinematic = false;
        rb.detectCollisions = true;
        transform.position = objPosition;
        Waterfall.SetActive(true);
        WiltedSeeds.SetActive(false);
        Seeds.SetActive(true);
        rockCount++;
        print("ayyyy");
           

    }

    // Update is called once per frame

    void WaterRise()
    {
        if (RockTriggered)
        {
            Water.SetActive(true);
        }
    }
    void Update()
    {
        if(rockCount == 3)
        {
            RockTriggered = true;
            WaterRise();
        }
    }
}
