using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<RotateObject>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<RotateObject>().enabled = false;
    }
}
