using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectionPioneerScript : MonoBehaviour
{
    [SerializeField] PersonInfoScript[] doctorArray;
    [SerializeField] PersonInfoScript[] patientArray;
    private PersonInfoScript[] currentArray;

    //References
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] TextMeshProUGUI Description;
    [SerializeField] Image photo;

    bool doctorSelected = true;
    int currentID;

    IEnumerator PrintCooldown()
    {
        yield return new WaitForSeconds(1);
        Debug.Log(currentArray.Length);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentID = 0;
    }
    // Update is called once per frame
    void Update()
    {
        UpdatePersonInfo();
        // StartCoroutine(PrintCooldown());
    }

    public void NextPerson()
    {
        if (currentID >= currentArray.Length + 1)
        {
            currentID = 0;
        }
        else { currentID++; }

    }
    public void PrevPerson()
    {
        if (currentID <= -1)
        {
            currentID = 0;
        }
        else { currentID--; }
    }
    public void ToggleDoctor()
    {
        currentArray = doctorArray;
        currentID = 0;
    }
    public void TogglePatient()
    {
        currentArray = patientArray;
        currentID = 0;
    }

    public void UpdatePersonInfo()
    {
        if (currentArray != null)
        {
            PersonInfoScript currentPerson;

            currentPerson = currentArray[currentID];

            if (currentPerson != null)
            {
                //change UI
                Name.text = currentPerson.personName;
                Description.text = currentPerson.personDescription;
                photo.sprite = currentPerson.peronPhoto;
            }
            else { Debug.Log("Current Person Null"); }
        }
        else { Debug.Log("Current Array null"); }
    }
}
