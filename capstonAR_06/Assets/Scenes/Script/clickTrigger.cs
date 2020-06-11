using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickTrigger : MonoBehaviour
{
    //public GameObject Panel;
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "gjjmission")
                {
                    SceneManager.LoadScene("JUNG");
                }
                else if (hit.transform.name == "ghrmission")
                {
                    SceneManager.LoadScene("YONG");
                }
                else if (hit.transform.name == "gnjmission")
                {
                    SceneManager.LoadScene("ABIG");
                }
                else if (hit.transform.name == "yongsphere")
                {
                    SceneManager.LoadScene("MISSION3");
                }
            }
        }
    }
}
