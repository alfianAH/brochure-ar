using UnityEngine;
using UnityEngine.UI;

public class CheckHouse : MonoBehaviour
{
    [SerializeField] private SwipeHouse swipeHouse;
    [SerializeField] private Button leftButton, rightButton;
    [SerializeField] private Text houseTypeText;
    
    private int startHouse, lastHouse;

    private void Start()
    {
        startHouse = 0;
        lastHouse = swipeHouse.houses.Length - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        // If other is start house, ...
        if (other.gameObject == swipeHouse.houses[startHouse])
        {
            // Make left button's interactable to false
            leftButton.interactable = false;
        }
        else if(other.gameObject == swipeHouse.houses[lastHouse])
        {
            // Make rigtht button's interactable to false
            rightButton.interactable = false;
        }
        else
        {
            leftButton.interactable = true;
            rightButton.interactable = true;
        }

        houseTypeText.text = other.name;
    }
}
