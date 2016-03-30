using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
public class FogShift : MonoBehaviour {

    public GameObject MainCamera;
    public GameObject FogLerp;
    public float bloomFloat = 0.55f;
    float currentLerp = 0f;
    
    public Color fogEnd;

    bool LerpColorBool = false;
    
    void Awake()
    {
         //MainCamera.GetComponent<Bloom>().bloomIntensity = 0f;
    }
    void Update()
    {
        LerpFog();
    }
    // Use this for initialization
  void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MainCamera")
        {
            print("fogLerpworking");
            LerpColorBool = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            print("fogLerpworking");
            LerpColorBool = false;
        }
    }

    void LerpFog()
    {
        if (LerpColorBool)
        {
            currentLerp += Time.deltaTime;
            bloomFloat = 0.55f;
            MainCamera.GetComponent<Bloom>().bloomIntensity += Time.deltaTime;
        }
        else
        {
            currentLerp -= Time.deltaTime;
           
            bloomFloat -= Time.deltaTime;
            MainCamera.GetComponent<Bloom>().bloomIntensity -= Time.deltaTime;
        }

        currentLerp = Mathf.Clamp(currentLerp, 0f, 1f);
        MainCamera.GetComponent<Bloom>().bloomIntensity = Mathf.Clamp(bloomFloat, 0f, 0.55f);
    
        RenderSettings.fogColor = Color.Lerp(Color.white, fogEnd, currentLerp);
      
        
    }

   
}
