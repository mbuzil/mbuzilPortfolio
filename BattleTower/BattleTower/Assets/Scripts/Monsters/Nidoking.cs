using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nidoking : Monster
{
    public Nidoking()
    {
        name = "Nidoking";
        type1 = "Ground";
        type2 = "Poison";
        baseStats[0] = 81;
        baseStats[1] = 102;
        baseStats[2] = 77;
        baseStats[3] = 85;
        baseStats[4] = 75;
        baseStats[5] = 85;
        moveList.Add(1);
        moveList.Add(2);
        moveList.Add(3);
        moveList.Add(3);
        EV[0] = 0;
        EV[1] = 0;
        EV[2] = 0;
        EV[3] = 0;
        EV[4] = 0;
        EV[5] = 0;
    }
}
