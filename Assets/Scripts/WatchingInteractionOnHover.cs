using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WatchingInteractionOnHover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRSimpleInteractable touched = GetComponent<XRSimpleInteractable>();
        touched.hoverEntered.AddListener(OpenMenu);
    }

    private void OpenMenu(HoverEnterEventArgs arg)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
