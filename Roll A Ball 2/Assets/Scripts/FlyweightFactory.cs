using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightFactory : MonoBehaviour {

    //this is where the objects are created and returned into the main program
	public Enemyship initShip(string ship) {

        Enemyship enemyShip = null;

        if (ship.Equals("UFO")) {
            return new Ufo();
        } else if (ship.Equals("MOTHERSHIP")) {
            return new Mothership();
        } else {
            return null;
        }
    }

}
