using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{

    public void MoveToDago()
    {
        Application.LoadLevel("DagoScene");
    }

    public void MoveToSmartBuilding()
    {
        Application.LoadLevel("SmartBuilding");
    }
}
