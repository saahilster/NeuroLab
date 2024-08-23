using TMPro;
using UnityEngine;

public class ObjectMovements : MonoBehaviour
{
    //reference
    [SerializeField] Transform spawnPoint;
    [SerializeField] bool isNested;
    private Vector3 spawnPosition = new Vector3(0, 1.443f, 0.774f);
    [SerializeField] GameObject model;
    [SerializeField] GameObject part;
    private bool Spawn = false;

    //info 
    [SerializeField] GameObject childObject;
    [SerializeField, HideInInspector] SubjectInfo info;

    //UI reference
    [SerializeField] TextMeshProUGUI subjectName;
    [SerializeField] TextMeshProUGUI descriptionHeader;
    [SerializeField] TextMeshProUGUI description;

    private void Update()
    {

    }
    public void objectSpawnFunction()
    {
        Debug.Log("spawned");
        part = Instantiate(model, spawnPosition, Quaternion.identity);
        part.transform.position = spawnPosition;
       // UpdateUI();
        Spawn = true;

        if (isNested)
        {
            Destroy(gameObject); 
        }
    }
    public SubjectInfo GetObjectInfo()
    {
        SubjectInfo partInfo = part.GetComponent<ObjectOnSpawn>().objectData;
        return partInfo;
    }

    public void UpdateUI()
    {
        info = GetObjectInfo();

        subjectName.text = info.name;
        descriptionHeader.text = info.description;
        description.text = info.description;
    }
}
