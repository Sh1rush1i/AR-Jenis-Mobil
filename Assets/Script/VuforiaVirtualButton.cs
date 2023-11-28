using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VuforiaVirtualButton : MonoBehaviour
{
    [Header("Main Settings")]
    public VirtualButtonBehaviour VirtualButton;

    [Header("Event Settings")]
    public UnityEvent OnPressedEvent;
    public UnityEvent OnReleasedEvent;


    // Start is called before the first frame update
    void Start()
    {
        VirtualButton.RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        OnPressedEvent.Invoke();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        OnReleasedEvent.Invoke();
    }
}

