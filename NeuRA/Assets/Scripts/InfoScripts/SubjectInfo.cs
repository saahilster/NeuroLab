using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SubjectData", menuName = "Subject Info")]
public class SubjectInfo : ScriptableObject
{
    public new string name;
    public string subName;
    public GameObject parentObject;
    public GameObject childObject;
    public string description;
    public int PatientID;
}
