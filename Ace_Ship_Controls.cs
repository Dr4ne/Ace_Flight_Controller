using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ace_Ship_Controls : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody _rigidBody;

    [Header("Thrust & Velocity")]
    public float _thrust = 0f;
    public float _thrustForce = 100f;
    [SerializeField] private float _maxBackwardThrust = -20f;
    public float _maxForwardThrust = 200f;
    [SerializeField] private float _maxSpeed = 200f;
    public Vector2 _moveInput = new Vector2(0, 0);

    [Header("Gravity")]
    [SerializeField] private bool _isGravityOn = false;
    [SerializeField] private float _gravityScale = 1.0f;
    [SerializeField] private static float _globalGravity = -9.81f;

    [Header("Mouse Position")]
    [SerializeField] private float _mouseDeadZone = 0.33f;
    //[SerializeField] private float _mouseSensitivity = 1f;
    //[SerializeField] private AnimationCurve _mouseInputCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
    //private float _mouseInputCurveFloat;
    //[SerializeField] private float _mouseCurveMultiplier = 1;
    private Vector2 _mouseScreenPosition;
    private Vector2 _adjustedScreenPosition;

    [Header("Pitch / Yaw / Roll")]
    [SerializeField] private float _pitch = 0f;
    [SerializeField] private float _pitchForce = 2f;
    [SerializeField] private float _yaw = 0f;
    [SerializeField] private float _yawForce = 1.5f;
    public float _roll = 0f;
    public float _rollForce = 1f;
    [SerializeField] private float _rollForceMouseMultiplier = 1f;

    [Header("Air Resistance")]
    public float _speed = 0f;
    [SerializeField] private float _airResistance = 0f;
    [SerializeField] private float _airResistanceFactor = 1f;
    [SerializeField] private float _maxDrag = 5f;
    [SerializeField] private float _maxAngularDrag = 5f;

    [Header("Misc")]
    [SerializeField] private bool _isLocked;
    [SerializeField] private bool _steerVelocityLock;
    public float _aimDistance = 10f;


    // Move

    public void MoveInput(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }

    private void Move()
    {
        if (_isLocked == false)
        {
            _thrust += _moveInput.y * _thrustForce;
            _thrust = Mathf.Clamp(_thrust, _maxBackwardThrust, _maxForwardThrust);
            _rigidBody.AddRelativeForce(-Vector3.forward * _thrust, ForceMode.Acceleration);

            if (_moveInput.x != 0)
            {
                _roll = _moveInput.x * _rollForce;
                _rigidBody.AddRelativeTorque(-Vector3.forward * -_roll, ForceMode.Acceleration);
            }

            _rigidBody.velocity = Vector3.ClampMagnitude(_rigidBody.velocity, _maxSpeed);
        }
    }

    private void Gravity()
    {
        if (_isGravityOn == true)
        {
            Vector3 gravity = _globalGravity * _gravityScale * Vector3.up;
            if (transform.position.y > 10)
            {
                _rigidBody.AddForce(gravity, ForceMode.Acceleration);
            }
        }
    }

    private void AirResistance()
    {
        _speed = _rigidBody.velocity.magnitude;
        float _airResPercent = _maxSpeed * _airResistanceFactor / 100f;
        _airResistance = Mathf.Clamp(_speed / 100, 0, _maxSpeed / 100f);
        _rigidBody.drag = Mathf.Clamp(_rigidBody.drag * _airResistance, 1, _maxDrag);
        _rigidBody.angularDrag = Mathf.Clamp(_rigidBody.angularDrag * _airResistance, 1, _maxAngularDrag);
    }


    // Mouse Steer

    private void MousePosition()
    {
        _mouseScreenPosition = Camera.main.ScreenToViewportPoint(Mouse.current.position.ReadValue());
        _adjustedScreenPosition = new Vector2(_mouseScreenPosition.x * 2f - 1f, _mouseScreenPosition.y * 2f - 1f);
        //_mouseInputCurveFloat = _mouseInputCurve.Evaluate(_adjustedScreenPosition.y);
        //_adjustedScreenPosition.x = _mouseInputCurveFloat * _mouseCurveMultiplier;
        //_adjustedScreenPosition.y = _mouseInputCurveFloat * _mouseCurveMultiplier;
    }

    private void MouseSteer()
    {

        if (_isLocked == false)
        {
            //if (_adjustedScreenPosition.y != 0.0f)
            if (Math.Abs(_adjustedScreenPosition.y) > _mouseDeadZone)
                {
                _pitch = _adjustedScreenPosition.y * _pitchForce;
                if (_steerVelocityLock == true)
                {
                    _pitch = _pitch * Mathf.Clamp(_airResistance, 0, 1);
                }
                _rigidBody.AddRelativeTorque(Vector3.right * _pitch, ForceMode.Force);
            }


            if (_adjustedScreenPosition.x != 0.0f)
            {
                _yaw = _adjustedScreenPosition.x * _yawForce;
                if (_steerVelocityLock == true)
                {
                    _yaw = _yaw * Mathf.Clamp(_airResistance, 0, 1);
                }
                _rigidBody.AddRelativeTorque(new Vector3(0, 0, 1) * _yaw, ForceMode.Force);
            }


            if (_adjustedScreenPosition.x != 0.0f)
            {
                _roll = _adjustedScreenPosition.x * _rollForce * _rollForceMouseMultiplier;
                if (_steerVelocityLock == true)
                {
                    _roll = _roll * Mathf.Clamp(_airResistance, 0, 1);
                }
                _rigidBody.AddRelativeTorque(Vector3.up * _roll, ForceMode.Acceleration);
            }
        }

    }



    // Misc

    private Quaternion Damp(Quaternion a, Quaternion b, float lambda, float dt)
    {
        return Quaternion.Slerp(a, b, 1 - Mathf.Exp(-lambda * dt));
        // Credits: http://www.rorydriscoll.com/2016/03/07/frame-rate-independent-damping-using-lerp/
    }

    public void FullUnlock(InputAction.CallbackContext context)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;
        _isLocked = false;
        _isGravityOn = true;
    }

    public void SteerVelocitySwitch(InputAction.CallbackContext context)
    {
        switch (_steerVelocityLock)
        {
            case true:
                //Debug.Log("Steer Velocity Lock: OFF");
                _steerVelocityLock = false;
                break;
            case false:
                //Debug.Log("Steer Velocity Lock: ON");
                _steerVelocityLock = true;
                break;
        }
    }

    private void StartReset()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _isLocked = true;
        _isGravityOn = false;
        _rigidBody.Sleep();
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.useGravity = false;
        _steerVelocityLock = true;
        StartReset();
    }

    private void FixedUpdate()
    {
        Move();
        MousePosition();
        MouseSteer();
        Gravity();
        AirResistance();
    }

    private void Update()
    {

    }

}
