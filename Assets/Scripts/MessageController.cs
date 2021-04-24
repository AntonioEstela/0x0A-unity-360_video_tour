using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    public GameObject Panel;

    public void ActivateMessage()
    {
        Panel.SetActive(!Panel.activeInHierarchy);
    }
}
