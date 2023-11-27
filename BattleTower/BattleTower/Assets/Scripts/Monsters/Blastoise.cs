using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastoise : Monster
{
    public Blastoise()
    {
        name = "Blastoise";
        type1 = "Water";
        type2 = null;
        baseStats[0] = 79;
        baseStats[1] = 83;
        baseStats[2] = 100;
        baseStats[3] = 85;
        baseStats[4] = 105;
        baseStats[5] = 78;
        moveList.Add(2);
        moveList.Add(6);
        moveList.Add(13);
        moveList.Add(15);
        EV[0] = 0;
        EV[1] = 0;
        EV[2] = 0;
        EV[3] = 0;
        EV[4] = 0;
        EV[5] = 0;
    }
}
