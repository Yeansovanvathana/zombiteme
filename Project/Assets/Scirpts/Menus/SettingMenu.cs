using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick_Back() { 
        MenuManager.OpenMenu(Menu.MAIN_MENU,gameObject);
    }
}
