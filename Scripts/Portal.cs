using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    public Transform exit;

    public string otherPortalTag;
    public GameObject otherPortal;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            otherPortal = GameObject.FindGameObjectWithTag(otherPortalTag);
            if (otherPortal != null)
            {
                coll.transform.position = otherPortal.GetComponent<Portal>().exit.position;
            }
        }
    }
}
