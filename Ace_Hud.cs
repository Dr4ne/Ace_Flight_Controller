using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Ace_Hud : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform _shipTransform = null;
    [SerializeField] private Ace_Ship_Controls _shipControls = null;
    [SerializeField] private Ace_Laps _lapsControls = null;

    [Header("HUD Elements")]
    [SerializeField] private RectTransform _boresightReticle = null;
    [SerializeField] private RectTransform _mouseReticule = null;
    [SerializeField] private Text _thrustValue = null;
    [SerializeField] private Text _speedValue = null;
    [SerializeField] private Text _LapsValue = null;


    private Vector2 _mouseScreenPosition;
    private Vector2 _screenSizeMousePos;
    private float _mouseBorder;
    private Vector3 _boreSight;

    private Camera playerCam = null;

    private void Boresight(Transform trans, Ace_Ship_Controls controller)
    {
        _boreSight = trans.transform.forward * controller._aimDistance + trans.transform.position;
    }

    private void MousePosition()
    {
        _mouseScreenPosition = Camera.main.ScreenToViewportPoint(Mouse.current.position.ReadValue());
        _screenSizeMousePos = new Vector2(_mouseScreenPosition.x * Screen.width, _mouseScreenPosition.y * Screen.height);
        _mouseBorder = _mouseReticule.rect.width / 2f;
        _screenSizeMousePos.x = Mathf.Clamp(_screenSizeMousePos.x, 0 + _mouseBorder, Screen.width - _mouseBorder);
        _screenSizeMousePos.y = Mathf.Clamp(_screenSizeMousePos.y, 0 + _mouseBorder, Screen.height - _mouseBorder);
    }

    private void MousePositionHUD(Ace_Ship_Controls controller)
    {
        if (_boresightReticle != null)
        {
            _boresightReticle.position = Camera.main.WorldToScreenPoint(_boreSight);
        }

        if (_mouseReticule != null)
        {
            _mouseReticule.position = _screenSizeMousePos;
        }
        //Debug.Log("Boresight: " + _boresightReticle.position + "    MousePos: " + _screenSizeMousePos);
    }

    private void TextsHUD()
    {
        int _thrustInt = Mathf.RoundToInt(_shipControls._thrust);
        _thrustValue.text = _thrustInt.ToString();    
        int _speedInt = Mathf.RoundToInt(_shipControls._speed);
        _speedValue.text = _speedInt.ToString();
        _LapsValue.text = _lapsControls._currentLapCount.ToString();
    }

    private void Awake()
    {
        if (_shipControls == null)
            Debug.LogError(name + ": Hud - Mouse Flight Controller not assigned!");

        playerCam = Camera.main;

        if (playerCam == null)
            Debug.LogError(name + ": Hud - No camera found !");
    }

    private void FixedUpdate()
    {
        Boresight(_shipTransform, _shipControls);
    }
    void Update()
    {
        if (_shipControls == null || playerCam == null)
            return;


        MousePosition();
        MousePositionHUD(_shipControls);
        TextsHUD();

    }
}
