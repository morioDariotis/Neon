using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "try_again_button":
                Application.LoadLevel("sd");
                break;

        }
    }

   
}
