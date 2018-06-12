using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject Bullet;
    public GameObject obstacle;
    public GameObject collectable;
    public GameObject bigCollectable;
    public float chanceNumber;
    public float chanceMin;
    public float chanceMax;
    public float chanceThresh;
    public float chanceThresh2;
    public GameObject bulletEmitter1;
    public float Bullet_Forward_Force;
    public float bulletLifetime;

    public float shootDelayMin;
    public float shootDelayMax;
    public float forceMin;
    public float forceMax;

    public bool canShoot;

	// Use this for initialization
	void Start () {
        StartCoroutine(ShootWarmup());

    }

    // Update is called once per frame
    void Update () {

        Bullet_Forward_Force = Random.Range(forceMin, forceMax);
        chanceNumber = Random.Range(chanceMin, chanceMax);

        if (chanceNumber < chanceThresh)
        {
            if (chanceNumber <= chanceThresh2)
            {
                Bullet = bigCollectable;
            }
            if (chanceNumber > chanceThresh2)
            {
                Bullet = collectable;
            }
        }
        if (chanceNumber > chanceThresh)
        {
            Bullet = obstacle;
        }

        if (canShoot == true)
        {
            //The Bullet Instantiation happens here.
            GameObject Temporary_Bullet_handler;

            Temporary_Bullet_handler = Instantiate(Bullet, bulletEmitter1.transform.position, bulletEmitter1.transform.rotation) as GameObject;
            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and/or angle based on your particular mesh.
            Temporary_Bullet_handler.transform.Rotate(Vector3.left);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force, ForceMode.Impulse);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_handler, bulletLifetime);

            canShoot = false;
            StartCoroutine(ShootWarmup());

        }

        
		
	}
    IEnumerator ShootWarmup()
    {
        yield return new WaitForSeconds(Random.Range(shootDelayMin, shootDelayMax));
        canShoot = true;
    }
}
