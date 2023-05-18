using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public IEnumerator PopupDisable(float seconds)
    {    
        yield return new WaitForSeconds(seconds);

        gameObject.SetActive(false);
    }

    public void PopupEnable()
    {
        gameObject.SetActive(true);
        StartCoroutine(PopupDisable(2.5f));
    }
}
