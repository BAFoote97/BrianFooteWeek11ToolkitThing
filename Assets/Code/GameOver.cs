using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public GameObject Player;

    public AudioSource SFX;

    public GameObject youDead;
    public float textTime1;

    public GameObject friends;
    public float textTime2;

    public GameObject family;
    public float textTime3;

    public GameObject pets;
    public float textTime4;

    public GameObject mom;
    public float textTime5;

    public GameObject suck;
    public float textTime6;

    public GameObject world;
    public float textTime7;

    public GameObject hell;
    public float textTime8;

    public GameObject liveWithIt;
    public float textTime9;

    public GameObject gameOver;
    public float textTime10;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player == null)
        {
            SFX.enabled = true;
            StartCoroutine(BeginHumiliation());
        }
		
	}

    IEnumerator BeginHumiliation()
    {
        yield return new WaitForSeconds(textTime1);
        youDead.SetActive(true);

        yield return new WaitForSeconds(textTime2);
        friends.SetActive(true);

        yield return new WaitForSeconds(textTime3);
        family.SetActive(true);

        yield return new WaitForSeconds(textTime4);
        pets.SetActive(true);

        yield return new WaitForSeconds(textTime5);
        mom.SetActive(true);

        yield return new WaitForSeconds(textTime6);
        suck.SetActive(true);

        yield return new WaitForSeconds(textTime7);
        world.SetActive(true);

        yield return new WaitForSeconds(textTime8);
        hell.SetActive(true);

        yield return new WaitForSeconds(textTime9);
        liveWithIt.SetActive(true);

        yield return new WaitForSeconds(textTime10);
        gameOver.SetActive(true);

        yield return null;
    }
}
