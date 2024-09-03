using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PersonData", menuName = "Person Info")]
public class PersonInfoScript : ScriptableObject
{
    public string personName;
    public Sprite peronPhoto;
    public string personDescription;
}
