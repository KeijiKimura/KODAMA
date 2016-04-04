using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KodamaBorn : MonoBehaviour {



    public Transform kodamaFrom;
    public Transform kodamaTo;
    public float percentage = 0f;
    public static NiceSceneTransition instance;


    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(KodamaRaise());
        


        FinalCamMove.kodamaBorn = true;
    }

    IEnumerator KodamaRaise()
    {
        yield return new WaitForSeconds(7);
        moveKodama();
        yield return new WaitForSeconds(3);
        LoadNextScene();
       // StartCoroutine(EndScene());
        

    }

    void moveKodama()
    {
        print("KodamaRaise");
        percentage += Time.deltaTime / 1f;

        transform.position = Vector3.Lerp(kodamaFrom.position, kodamaTo.position, percentage);

    }

  /*  IEnumerator EndScene()
    {
        yield return new WaitForSeconds(3);
        LoadNextScene();
    }
    */
    void LoadNextScene()
    {
        if (NiceSceneTransition.instance != null)
        {
            NiceSceneTransition.instance.LoadScene("LightProto");
        }
        else
        {
            SceneManager.LoadScene("LightProto", LoadSceneMode.Single);


        }
    }

}
