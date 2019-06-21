using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject win_panel;
    public GameObject Car;
    private void OnTriggerStay2D(Collider2D collision)
    {
        win_panel.active = true;
        //Destroy(Car);
    }
}
