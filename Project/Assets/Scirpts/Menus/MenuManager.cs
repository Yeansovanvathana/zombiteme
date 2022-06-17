using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager
{
    public static bool IsInitialised{
        get; private set;
    }
    public static GameObject mainMenu, settingMenu, infoMenu;
    public static void Init() {
        GameObject canvas = GameObject.Find("Canvas");
        mainMenu = canvas.transform.Find("MainMenu").gameObject;
        settingMenu = canvas.transform.Find("SettingPopup").gameObject;
        infoMenu = canvas.transform.Find("InfoMenu").gameObject;

        IsInitialised = true; 
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu) {
        if(!IsInitialised)
            Init();
        switch (menu) {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                settingMenu.SetActive(false);
                infoMenu.SetActive(false);
                break;
            case Menu.SETTINGS:
                mainMenu.SetActive(false);
                settingMenu.SetActive(true);
                infoMenu.SetActive(false);
                break;
            case Menu.Info:
                mainMenu.SetActive(false);
                settingMenu.SetActive(false);
                infoMenu.SetActive(true);
                break;
        }
        callingMenu.SetActive(false);
    }

    }

