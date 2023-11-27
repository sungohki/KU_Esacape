using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]

public class PlayerHandAnimate : MonoBehaviour
{
    [SerializeField] private InputActionReference gripInputActionRef;
    [SerializeField] private InputActionReference triggerInputActionRef;

    private Animator _handAnimator;
    private float _gripValue;
    private float _triggerValue;

    private void Awake()
    {
        _handAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }

    private void AnimateGrip()
    {
        _gripValue = gripInputActionRef.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    }

    private void AnimateTrigger()
    {
        _triggerValue = triggerInputActionRef.action.ReadValue<float>();
        _handAnimator.SetFloat("Trigger", _triggerValue);
    }
}
