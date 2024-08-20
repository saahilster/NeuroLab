using UnityEngine;

public class HoverBehaviors : MonoBehaviour
{
    [SerializeField] Material materialDefault;
    [SerializeField] Material hoveredMaterial;
    [SerializeField] Material selectedMaterial;
    private Renderer currentMaterial;

    //spawn object
    [SerializeField] private GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        currentMaterial = GetComponent<Renderer>();
        currentMaterial.material = materialDefault;
    }

    public void OnHoverChange()
    {
        currentMaterial.material = hoveredMaterial;
    }

    public void RevertMaterial()
    {
        currentMaterial.material = materialDefault;
    }
    public void OnSelectMaterial()
    {
        currentMaterial.material = selectedMaterial;
    }
}
