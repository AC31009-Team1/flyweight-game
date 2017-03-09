using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemyship : MonoBehaviour {

    //this class determines the shared state of objects, their shape and actions, we also store the non-shared state here too but this is set upon creation and immutable


    private string shipName;





    public string getShipName() {
        return shipName;
    }

    public void setShipName(string input) {
        this.shipName = input;
    }

    public void shipAction() {
        Console.WriteLine(getShipName() + " is performing an action");
    }

	public void getShip(int rSx, int rSz, float wallPos, String t) {
 		
		//random x and z?
		if(t.Equals("UFO")){
			 GameObject ship = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Rigidbody rigidbody = ship.AddComponent<Rigidbody> ();
			ship.transform.position = new Vector3(rSx , 0 , rSz);
		}
		else if(t.Equals("MOTHERSHIP")){
			GameObject ship2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
			ship2.transform.localScale += new Vector3(5.0F, 0, 0);
			//if (wallPos >= 1) {
			//ship2.transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
			//}
			Rigidbody rigidbody2 = ship2.AddComponent<Rigidbody> ();
			ship2.transform.position = new Vector3(rSx , 0 , rSz);
		}

    }

	public void followPlayer(){
		
	}
}
