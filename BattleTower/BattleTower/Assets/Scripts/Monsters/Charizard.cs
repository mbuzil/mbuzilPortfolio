using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charizard : Monster
{
    public Charizard()
    {
        name = "Charizard";
        type1 = "Fire";
        type2 = "Flying";
        baseStats[0] = 78;
        baseStats[1] = 84;
        baseStats[2] = 78;
        baseStats[3] = 109;
        baseStats[4] = 85;
        baseStats[5] = 100;
        moveList.Add(3);
        moveList.Add(10);
        moveList.Add(13);
        moveList.Add(17);
        EV[0] = 0;
        EV[1] = 0;
        EV[2] = 0;
        EV[3] = 0;
        EV[4] = 0;
        EV[5] = 0;
    }
}