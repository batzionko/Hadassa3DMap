using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour
{
    public GameObject panel;

    public void hidePanel()
    {
        panel.gameObject.SetActive(false);
    }
    public void showPanel()
    {
        panel.gameObject.SetActive(true);
    }
}
