using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    private bool sw = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("1key"))
        {
            if (sw) {
                cam1.SetActive(false);
                cam2.SetActive(true);
                sw = false;
            } else
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                sw = true;
            }
        }

    }
}
