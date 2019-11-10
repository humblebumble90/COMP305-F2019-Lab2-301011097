using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Name:Hyungseok Lee
//Studentnumber:301011097

[CreateAssetMenu(fileName ="ScoreBoard", menuName ="Game/ScoreBoard")]
[System.Serializable]
public class ScoreBoard : ScriptableObject
{
    public int highScore;
    public int lives;
    public int score;
}
