using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowController : MonoBehaviour
{
    public GameObject bolt;

    public Transform shootPoint;

    //shooting
    public float shootForce;

    public float reloadTime = 2f;
    private float nextFireTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Time.time > nextFireTime)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    nextFireTime = Time.time + reloadTime;
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
