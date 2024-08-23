using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CollisionInfoScript : MonoBehaviour
{
    public SubjectInfo itemInfo;
    public UnityEvent updateUI;

    // [SerializeField] GameObject subjectNameOBJ;
    //[SerializeField] GameObject bodyNameOBJ;
    //[SerializeField] GameObject bodyHeaderyObj;

    //Text assigned through start
    [SerializeField] TextMeshProUGUI subjectName;
    [SerializeField] TextMeshProUGUI descriptionHeader;
    [SerializeField] TextMeshProUGUI description;

    [SerializeField] GameObject objSelected;
    bool objectDetected;
    // Start is called before the first frame update
    void Start()
    {
        objectDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        updateData();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "interactable")
        {
            Debug.LogWarning("Object name: " + other.gameObject.name);
            objSelected = other.gameObject;
            ObjectOnSpawn objScript;
            if (objSelected != null)
            {
                Debug.Log("Item Found");
                objScript = objSelected.GetComponent<ObjectOnSpawn>();
                if (objScript != null)
                {
                    itemInfo = objScript.objectData;
                    objectDetected = true;
                    Debug.Log("Data found");
                }
                else
                {
                    Debug.Log("Not found");
                }
            }
        }
        else
        {
            Debug.Log("Interact obj not found");
        }
    }

    public void deleteCurrentData()
    {
        itemInfo = null;
        subjectName.text = "Nothing Selected";
        description.text = "Please select a body part to display description!";
        descriptionHeader.text = "Nothing Selected";
        if (objSelected != null)
        {
            Destroy(objSelected);
        }

    }
    public void updateData()
    {
        if (itemInfo != null)
        {
            subjectName.text = itemInfo.name;
            description.text = itemInfo.description;
            descriptionHeader.text = itemInfo.name;
        }
        else
        {
           // Debug.Log("Nothing Selected");
        }
    }
}
