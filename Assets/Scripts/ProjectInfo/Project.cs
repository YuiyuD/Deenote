﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[System.Serializable]
public class Project //Saves the project info and settings, audio clip not included
{
    //Project info
    public string name = ""; //The name of the project
    public string chartMaker = ""; //The name of the chart maker
    public string songName = ""; //The name of the song (the file)(includes extension) - cannot be changed after creating the project
    public Chart[] charts = { }; //Charts in the project
    //Project settings
}
