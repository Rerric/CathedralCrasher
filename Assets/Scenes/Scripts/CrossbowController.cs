using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowController : MonoBehaviour
{
    public GameObject bolt;

    public Transform shootPoint;

    //shooting
    public float shootForce;

    public float reloadTime;

    private bool isLoaded;

    // Start is called before the first frame update
    void Start()
    {
        isLoaded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLoaded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //isLoaded = false;
                FireBolt();
            }
        }
    }

    private void FireBolt()
    {
        GameObject currentBolt = Instantiate(bolt, shootPoint.position, shootPoint.rotation);
        Rigidbody rig = currentBolt.GetComponent<Rigidbody>();

        rig.AddForce(shootPoint.up * shootForce, ForceMode.Impulse);
    }
}
