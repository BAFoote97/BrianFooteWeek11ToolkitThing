using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScript : MonoBehaviour {
    public GameObject prefab;
    public GameObject position1;
    public GameObject position2;
    public bool spawn1;
    public bool spawn2;

    public float score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();

        


    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Collectable")
        {
            Destroy(other.gameObject);
            score += other.gameObject.GetComponent<ScoreHolder>().scoreValue;
        }
    }

}
