using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public GameObject mainMenu;

    public void showMainMenu()
    {
        mainMenu.SetActive(true);
    }

    public void hideMainMenu()
    {
        mainMenu.SetActive(false);
    }


}
