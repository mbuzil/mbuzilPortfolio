using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public int CalculateDamage(Move move, Monster m1, Monster m2)
    {
        double typeEffectiveness = CalculateEffectiveness(move.type, m2.type1, m2.type2);
        float damage = 42f;
        float attackOverDefense = 0;
        damage *= move.baseDamage;
        if(move.physical == true)
            attackOverDefense = m1.finalStats[2] / m2.finalStats[3];
        else
            attackOverDefense = m1.finalStats[4] / m2.finalStats[5];
        damage *= attackOverDefense;
        damage /= 50;
        damage += 2;
        //additional calcs for things not implemented yet: Weather, critical hit, burn
        if (move.type == m1.type1 || move.type == m1.type2)
            damage *= 1.5;
        damage *= typeEffectiveness;
        int final = (int)damage;
        return damage;
    }
    public double CalculateEffectiveness(string moveType, string type1, string type2)
    {
        double effective = 1;
        if(moveType == "Normal")
        {
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            else if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 0;
            else if(type1 == "Steel" || type2 == "Steel")
                    effective *= 0.5;
        }
        else if(moveType == "Fire")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            else if (type1 == "Water" || type2 == "Water")
                effective *= 0.5;
            else if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            else if (type1 == "Ice" || type2 == "Ice")
                effective *= 2;
            else if (type1 == "Bug" || type2 == "Bug")
                effective *= 2;
            else if (type1 == "Rock"|| type2 == "Rock")
                effective *= 0.5;
            else if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 0.5;
            else if (type1 == "Steel" || type2 == "Steel")
                effective *= 2;
        }
    }
}
