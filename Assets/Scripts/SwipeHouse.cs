using UnityEngine;

public class SwipeHouse : MonoBehaviour
{
    public GameObject[] houses;

    public void SwipeRight()
    {
        foreach (var house in houses)
        {
            house.transform.position =
                new Vector3(house.transform.position.x - 50f,
                    house.transform.position.y, 
                    house.transform.position.z);
        }
    }

    public void SwipeLeft()
    {
        foreach (var house in houses)
        {
            house.transform.position =
                new Vector3(house.transform.position.x + 50f,
                    house.transform.position.y, 
                    house.transform.position.z);
        }
    }
}
