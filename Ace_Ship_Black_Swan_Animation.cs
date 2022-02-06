using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ace_Ship_Black_Swan_Animation : MonoBehaviour
{
    [Header("Commponents")]
    [SerializeField] private Ace_Ship_Controls _controls = null;
    [SerializeField] private float _thrust = 0.0f;
    [Space(10)]
    [SerializeField] private Animator _animMain = null;
    [SerializeField] private Animator _animLW = null;
    [SerializeField] private Animator _animRW = null;
    [SerializeField] private float _blendValue = 0.0f;

    private void ThrustUpdate()
    {
        _thrust = _controls._thrust;
    }

    private void isIdle()
    {
        if (_thrust != 0)
        {
            _animMain.SetBool("isIdle", false);
            _animLW.SetBool("isIdle", false);
            _animRW.SetBool("isIdle", false);
        }
        else
        {
            _animMain.SetBool("isIdle", true);
            _animLW.SetBool("isIdle", true);
            _animRW.SetBool("isIdle", true);
        }
    }

    private void Blend()
    {
        _blendValue = _thrust / _controls._maxForwardThrust;
        _animMain.SetFloat("Blend", _blendValue);
        _animLW.SetFloat("Blend", _blendValue);
        _animRW.SetFloat("Blend", _blendValue);
    }

    void Update()
    {
        ThrustUpdate();
        //isIdle();
        Blend();
    }
}
