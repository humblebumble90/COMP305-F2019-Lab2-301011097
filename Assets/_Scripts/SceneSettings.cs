﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Name:Hyungseok Lee
//Studentnumber:301011097

[CreateAssetMenu(fileName = "SceneSettings", menuName ="Scene/Settings")]
[System.Serializable]

public class SceneSettings : ScriptableObject
{
    [Header("Scene Configuration")]
    public Scene scene;
    public SoundClip activeSoundClip;

    [Header("Scoreboard ")]
    public bool scoreLabelEnabled;
     public bool livesLabelEnabled;
     public bool highScoreLabelEnabled;

    [Header("Scene Labels")]
    public bool startLabelActive;
    public bool endLabelSetActive;


    [Header("Scene buttons")]
    public bool startButtonActive;
    public bool restartButtonActive;

}
