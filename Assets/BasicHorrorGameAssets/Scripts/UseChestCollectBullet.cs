using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseChestCollectBullet : MonoBehaviour
{
    private GameObject OB;
    public GameObject handUI;
    public GameObject objToActivate;
    public Pistol pistol;
    private int count = 0;
    private bool inReach;


    void Start()
    {

        OB = this.gameObject;

        handUI.SetActive(false);

        objToActivate.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            handUI.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            handUI.SetActive(false);
        }
    }

    void Update()
    {


        if (inReach && Input.GetButtonDown("Interact")&& count==0)
        {
            handUI.SetActive(false);
            objToActivate.SetActive(true);
            pistol.maxAmmoInMag += 10;
            OB.GetComponent<Animator>().SetBool("open", true);
            OB.GetComponent<BoxCollider>().enabled = false;
            count ++;
        }
    }

}
