using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mothership : Enemyship {


    // a simple object used only to determine the non-shared state of a potetional Mothership object
    public void MotherShipEnemy() {
        setShipName("Mothership");
    }
}
