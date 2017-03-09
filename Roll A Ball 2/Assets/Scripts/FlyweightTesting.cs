using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightTesting : MonoBehaviour {

    
    // creates the factory object
    FlyweightFactory flyweightFactory = new FlyweightFactory();

    Enemyship enemyShip = null;

    string shipType = null;

	float rN = 1;
	int rSx = 0;
	int rSz = 0;
	float wallPos = 0;
	public float spawnPeriod;
	private float nextSpawnTime;
	// Use this for initialization
	void Start () {
		nextSpawnTime = 1;
		spawnPeriod = 0.1f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		//Random rnd = new Random ();
		rN = Random.Range ( 0.0f, 2.0f);
		wallPos = Random.Range ( 0.0f, 2.0f);
		rSx = Random.Range (-45, 45);
		rSz = Random.Range (-25, 25);
		spawnEnemy();
        //gathers user input to define the extrinsic state of the object being created (name/type)
    }

	void spawnEnemy(){
		float TempR = rN;
		//int TempR = 2;
		if (TempR <=1 && Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + spawnPeriod;
			shipType = "UFO";
			enemyShip = flyweightFactory.initShip(shipType);
			enemyActions(enemyShip,"UFO");
			//nextSpawnTime = spawnPeriod;

		} else if (TempR >=1 && Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + spawnPeriod;
			shipType = "MOTHERSHIP";
			enemyShip = flyweightFactory.initShip(shipType);
			enemyActions(enemyShip,"MOTHERSHIP");

		} else { }
	}

	void playerInput(){
		if (Input.GetButtonDown("Fire1")) {
			shipType = "UFO";

			enemyShip = flyweightFactory.initShip(shipType);
			enemyActions(enemyShip,"UFO");
		} else if (Input.GetButtonDown("Jump")) {
			shipType = "MOTHERSHIP";

			enemyShip = flyweightFactory.initShip(shipType);
			enemyActions(enemyShip,"MOTHERSHIP");
		} else { }
	}
    //provides a set of actions for the object to perform, in this case, instantiate
	void enemyActions(Enemyship anEnemyShip, string t) {
        anEnemyShip.getShip(rSx, rSz, wallPos, t);
        anEnemyShip.shipAction();
    }
}
