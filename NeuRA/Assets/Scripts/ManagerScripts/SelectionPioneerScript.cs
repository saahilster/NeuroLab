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

    // Start is called before the first frame update
    void Start()
    {
        currentID = 0;
    }
    // Update is called once per frame
    void Update()
    {
        UpdatePersonInfo();
        ArrayCap();
    }

    public void NextPerson()
    {
        currentID++;
    }
    public void PrevPerson()
    {
        currentID--;
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
    private void ArrayCap()
    {
        if (currentArray != null)
        {
            if (currentID > currentArray.Length)
            {
                currentID = 0;
            }
            else if (currentID < 0)
            {
                currentID = currentArray.Length - 1;
            }
        }
    }
    public void UpdatePersonInfo()
    {
        PersonInfoScript currentPerson;

        currentPerson = currentArray[currentID];
        //change UI
        Name.text = currentPerson.personName;
        Description.text = currentPerson.personDescription;
        photo.sprite = currentPerson.peronPhoto;
    }
}
