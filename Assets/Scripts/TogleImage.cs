using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogleImage : MonoBehaviour
{
    [SerializeField] private Image customImage;
    private bool Show = false;
    private void Start()
    {
        customImage.enabled = false;
    }
    public void ChangeState()
    {
        if (Show == false)
        {
            customImage.enabled = true;
            Show = true;
        }
        else
        {
            customImage.enabled = false;
            Show = false;
        }
    }

    
}
