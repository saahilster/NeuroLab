using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "SubjectData", menuName = "Subject Info")]
public class SubjectInfo : ScriptableObject
{
    public new string name;
    public GameObject parentObject;
    public GameObject childObject;
    public string description;
    public Sprite SourceSprite;
    public string caption;

    //Video Player Info
    public string videoName;
    public VideoClip clip;
}
