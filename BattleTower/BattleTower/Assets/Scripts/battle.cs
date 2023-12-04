using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public double CalculateDamage(Move move, Monster m1, Monster m2)
    {
        double typeEffectiveness = CalculateEffectiveness(move.type, m2.type1, m2.type2);
        double damage = 42f;
        double attackOverDefense = 0;
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
        if (moveType == "Normal")
        {
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 0;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        else if (moveType == "Fire")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Water" || type2 == "Water")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            if (type1 == "Ice" || type2 == "Ice")
                effective *= 2;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 2;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 0.5;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 2;
        }
        else if (moveType == "Water")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 2;
            if (type1 == "Water" || type2 == "Water")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 2;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 2;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 0.5;
        }
        else if (moveType == "Electric")
        {
            if (type1 == "Water" || type2 == "Water")
                effective *= 2;
            if (type1 == "Electric" || type2 == "Electric")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 0;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 2;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 0.5;
        }
        else if (moveType == "Grass")
        {
            if (type1 == "Water" || type2 == "Water")
                effective *= 2;
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 0.5;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 2;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 0.5;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 0.5;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 0.5;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        else if (moveType == "Ice")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Water" || type2 == "Water")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            if (type1 == "Ice" || type2 == "Ice")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 2;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 2;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        else if (moveeType == "Fighting")
        {
            if (type1 == "Normal" || type2 == "Normal")
                effective *= 2;
            if (type1 == "Ice" || type2 == "Ice")
                effective *= 2;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 0.5;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 0.5;
            if (type1 == "Psychic" || type2 == "Psychic")
                effective *= 0.5;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 0.5;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 2;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 0;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 2;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 0.5;
        }
        else if (moveType == "Poison")
        {
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 0.5;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 0.5;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 2;
        }
        else if(moveType == "Ground")
        {
             if (type1 == "Fire" || type2 == "Fire")
                effective *= 2;
            if (type1 == "Electric" || type2 == "Electric")
                effective *= 2;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 0.5;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 2;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 0;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 0.5;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 2;
        }
        else if(moveType == "Flying")
        {
            if (type1 == "Electric" || type2 == "Electric")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 2;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 2;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 0.5;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 2;
        }
        else if(moveType == "Psychic")
        {
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 2;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 2;
            if (type1 == "Psychic" || type2 == "Psychic")
                effective *= 0.5;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 0;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        else if(moveType == "Bug")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Grass" || type2 == "Grass")
                effective *= 2;
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 0.5;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 0.5;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 0.5;
            if (type1 == "Psychic" || type2 == "Psychic")
                effective *= 2;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 0.5;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 0.5;
        }
        else if(moveType == "Rock")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 2;
            if (type1 == "Ice" || type2 == "Ice")
                effective *= 2;
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 0.5;
            if (type1 == "Ground" || type2 == "Ground")
                effective *= 0.5;
            if (type1 == "Flying" || type2 == "Flying")
                effective *= 2;
            if (type1 == "Bug" || type2 == "Bug")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        else if(moveType == "Ghost")
        {
            if (type1 == "Normal" || type2 == "Normal")
                effective *= 0;
            if (type1 == "Psychic" || type2 == "Psychic")
                effective *= 2;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 2;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 2;
        }
        else if(moveType == "Dragon")
        {
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 0;
        }
        else if(moveType == "Dark")
        {
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 0.5;
            if (type1 == "Psychic" || type2 == "Psychic")
                effective *= 2;
            if (type1 == "Ghost" || type2 == "Ghost")
                effective *= 2;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 0.5;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 0.5;
        }
        else if(moveType == "Steel")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Water" || type2 == "Water")
                effective *= 0.5;
            if (type1 == "Electric" || type2 == "Electric")
                effective *= 0.5;
            if (type1 == "Ice" || type2 == "Ice")
                effective *= 2;
            if (type1 == "Rock" || type2 == "Rock")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
            if (type1 == "Fairy" || type2 == "Fairy")
                effective *= 2;
        }
        else if(moveType == "Fairy")
        {
            if (type1 == "Fire" || type2 == "Fire")
                effective *= 0.5;
            if (type1 == "Fighting" || type2 == "Fighting")
                effective *= 2;
            if (type1 == "Poison" || type2 == "Poison")
                effective *= 0.5;
            if (type1 == "Dragon" || type2 == "Dragon")
                effective *= 2;
            if (type1 == "Dark" || type2 == "Dark")
                effective *= 2;
            if (type1 == "Steel" || type2 == "Steel")
                effective *= 0.5;
        }
        return (effective);
    }
}
