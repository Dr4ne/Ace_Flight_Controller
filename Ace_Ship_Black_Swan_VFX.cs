using UnityEngine;
using UnityEngine.VFX;

public class Ace_Ship_Black_Swan_VFX : MonoBehaviour
{
    [Header("Commponents")]
    [SerializeField] private Ace_Ship_Controls _controls = null;
    [SerializeField] private float _thrust = 0.0f;
    [SerializeField] private float _roll = 0.0f;


    [Header("VFX")]
    [SerializeField] private VisualEffect _backLeftEngineTrails_LL = null;
    [SerializeField] private VisualEffect _backLeftEngineTrails_LC = null;
    [SerializeField] private VisualEffect _backLeftEngineTrails_LR = null;
    [Space(10)]
    [SerializeField] private VisualEffect _backRightEngineTrails_LL = null;
    [SerializeField] private VisualEffect _backRightEngineTrails_LC = null;
    [SerializeField] private VisualEffect _backRightEngineTrails_LR = null;
    [Space(10)]
    [SerializeField] private VisualEffect _frontLeftEngineTrails_LL = null;
    [SerializeField] private VisualEffect _frontLeftEngineTrails_LR = null;
    [Space(10)]
    [SerializeField] private VisualEffect _frontRightEngineTrails_LL = null;
    [SerializeField] private VisualEffect _frontRightEngineTrails_LR = null;
    [Space(10)]
    [SerializeField] private VisualEffect _backLeftEngineTrails_C = null;
    [SerializeField] private VisualEffect _backRightEngineTrails_C = null;
    [Space(10)]
    [SerializeField, Range(1000f, 5000f)] private float _VfxEngineSpawnRate = 1000f;
    [SerializeField, Range(500f, 5000f)] private float _VfxEngineCircleSpawnRate = 500f;
    [SerializeField, Range(0.052f, 0.1f)] private float _VfxEngineLifetime = 0.052f;
    [SerializeField, Range(1f, 2f)] private float _VfxEngineVeloMult = 1f;
    [SerializeField, Range(1f, 2f)] private float _VfxEngineCalcveloMult = 1f;
    [SerializeField, Range(0f, 1f)] private float _VfxEngineCircVeloMult = 1f;
    [SerializeField, Range(1f, 5f)] private float _VfxEngineCircCalcVeloMult = 1f;
    [SerializeField, Range(1f, 2f)] private float _VfxEngineSRMult = 1f;
    [SerializeField, Range(1f, 5f)] private float _VfxEngineCalcSRMult = 1f;
    [SerializeField, Range(1f, 5f)] private float _VfxEngineCircCalcSRMult = 1f;
    [SerializeField, Range(1f, 2f)] private float _VfxEngineLTMult = 1f;
    [SerializeField, Range(1f, 5f)] private float _VfxEngineCalcLTMult = 1f;
    [Space(10)]
    [SerializeField, Range(-34f, 100f)] private float _VfxEngBLLVelocityX = -34f;
    [SerializeField, Range(45f, 100f)] private float _VfxEngBLLVelocityZ = 45f;
    [SerializeField, Range(50f, 100f)] private float _VfxEngBLCVelocityZ = 50f;
    [SerializeField, Range(0.8f, 100f)] private float _VfxEngBLRVelocityX = 0.8f;
    [SerializeField, Range(50f, 100f)] private float _VfxEngBLRVelocityZ = 50f;
    [Space(10)]
    [SerializeField, Range(-34f, 100f)] private float _VfxEngBRLVelocityX = 34f;
    [SerializeField, Range(45f, 100f)] private float _VfxEngBRLVelocityZ = 45f;
    [SerializeField, Range(50f, 100f)] private float _VfxEngBRCVelocityZ = 50f;
    [SerializeField, Range(0.8f, 100f)] private float _VfxEngBRRVelocityX = 0.8f;
    [SerializeField, Range(50f, 100f)] private float _VfxEngBRRVelocityZ = 50f;
    [Space(10)]
    [SerializeField, Range(12.4f, 100f)] private float _VfxEngFLLVelocityX = 12.4f;
    [SerializeField, Range(20f, 100f)] private float _VfxEngFLLVelocityZ = 20f;
    [SerializeField, Range(5.3f, 100f)] private float _VfxEngFLRVelocityX = 5.3f;
    [SerializeField, Range(20f, 100f)] private float _VfxEngFLRVelocityZ = 20f;
    [Space(10)]
    [SerializeField, Range(12.4f, 100f)] private float _VfxEngFRLVelocityX = 12.4f;
    [SerializeField, Range(20f, 100f)] private float _VfxEngFRLVelocityZ = 20f;
    [SerializeField, Range(5.3f, 100f)] private float _VfxEngFRRVelocityX = 5.3f;
    [SerializeField, Range(20f, 100f)] private float _VfxEngFRRVelocityZ = 20f;
    [Space(10)]
    [SerializeField, Range(35f, 100f)] private float _VfxEngBCLVelocityZ = 35f;
    [SerializeField, Range(35f, 100f)] private float _VfxEngBCRVelocityZ = 35f;
    //[Space(10)]
    //[SerializeField] private Gradient _VfxengineColorGradiant;

    private void VfxEngineTrailsVelocity()
    {
        // velocity
        _VfxEngineCalcveloMult = Mathf.Abs(Mathf.Clamp(_VfxEngineVeloMult * _thrust / 100f + 1f, 1f, 1.15f));

        float _newVfxEngBLLVelocityX = _VfxEngBLLVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngBLLVelocityZ = _VfxEngBLLVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngBLCVelocityZ = _VfxEngBLCVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngBLRVelocityX = _VfxEngBLRVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngBLRVelocityZ = _VfxEngBLRVelocityZ * _VfxEngineCalcveloMult;

        float _newVfxEngBRLVelocityX = _VfxEngBRLVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngBRLVelocityZ = _VfxEngBRLVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngBRCVelocityZ = _VfxEngBRCVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngBRRVelocityX = _VfxEngBRRVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngBRRVelocityZ = _VfxEngBRRVelocityZ * _VfxEngineCalcveloMult;

        float _newVfxEngFLLVelocityX = _VfxEngFLLVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngFLLVelocityZ = _VfxEngFLLVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngFLRVelocityX = _VfxEngFLRVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngFLRVelocityZ = _VfxEngFLRVelocityZ * _VfxEngineCalcveloMult;

        float _newVfxEngFRLVelocityX = _VfxEngFRLVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngFRLVelocityZ = _VfxEngFRLVelocityZ * _VfxEngineCalcveloMult;
        float _newVfxEngFRRVelocityX = _VfxEngFRRVelocityX * _VfxEngineCalcveloMult;
        float _newVfxEngFRRVelocityZ = _VfxEngFRRVelocityZ * _VfxEngineCalcveloMult;

        _backLeftEngineTrails_LL.SetFloat("Velocity X", _newVfxEngBLLVelocityX);
        _backLeftEngineTrails_LL.SetFloat("Velocity Z", _newVfxEngBLLVelocityZ);
        _backLeftEngineTrails_LC.SetFloat("Velocity Z", _newVfxEngBLCVelocityZ);
        _backLeftEngineTrails_LR.SetFloat("Velocity X", _newVfxEngBLRVelocityX);
        _backLeftEngineTrails_LR.SetFloat("Velocity Z", _newVfxEngBLRVelocityZ);

        _backRightEngineTrails_LL.SetFloat("Velocity X", _newVfxEngBRLVelocityX);
        _backRightEngineTrails_LL.SetFloat("Velocity Z", _newVfxEngBRLVelocityZ);
        _backRightEngineTrails_LC.SetFloat("Velocity Z", _newVfxEngBRCVelocityZ);
        _backRightEngineTrails_LR.SetFloat("Velocity X", _newVfxEngBRRVelocityX);
        _backRightEngineTrails_LR.SetFloat("Velocity Z", _newVfxEngBRRVelocityZ);

        _frontLeftEngineTrails_LL.SetFloat("Velocity X", _newVfxEngFLLVelocityX);
        _frontLeftEngineTrails_LL.SetFloat("Velocity Z", _newVfxEngFLLVelocityZ);
        _frontLeftEngineTrails_LR.SetFloat("Velocity X", _newVfxEngFLRVelocityX);
        _frontLeftEngineTrails_LR.SetFloat("Velocity Z", _newVfxEngFLRVelocityZ);

        _frontRightEngineTrails_LL.SetFloat("Velocity X", _newVfxEngFRLVelocityX);
        _frontRightEngineTrails_LL.SetFloat("Velocity Z", _newVfxEngFRLVelocityZ);
        _frontRightEngineTrails_LR.SetFloat("Velocity X", _newVfxEngFRRVelocityX);
        _frontRightEngineTrails_LR.SetFloat("Velocity Z", _newVfxEngFRRVelocityZ);



    }

    private void VfxEngineTrailsCircleVelocity()
    {
        //_VfxEngineCircCalcVeloMult = Mathf.Abs(Mathf.Clamp(_VfxEngineCircVeloMult * _roll, 1f, 1.2f));
        _VfxEngineCircCalcVeloMult = _VfxEngineCircVeloMult * _roll;
        float _newVfxEngBCLVelocityZ = _VfxEngBCLVelocityZ * _VfxEngineCircCalcVeloMult;
        float _newVfxEngBCRVelocityZ = _VfxEngBCRVelocityZ * Mathf.Abs(_VfxEngineCircCalcVeloMult);

        _backLeftEngineTrails_C.SetFloat("Velocity Z", _VfxEngBCLVelocityZ);
        if (_controls._moveInput.x > 0)
        {
            _backLeftEngineTrails_C.SetFloat("Velocity Z", _newVfxEngBCLVelocityZ);
        }

        _backRightEngineTrails_C.SetFloat("Velocity Z", _VfxEngBCRVelocityZ);
        if (_controls._moveInput.x < 0)
        {
            _backRightEngineTrails_C.SetFloat("Velocity Z", _newVfxEngBCRVelocityZ);
        }



    }

    //private void VfxEngineColorOverLife()
    //{
    //    _backLeftEngineTrails_LL.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _backLeftEngineTrails_LC.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _backLeftEngineTrails_LR.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _backRightEngineTrails_LL.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _backRightEngineTrails_LC.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _backRightEngineTrails_LR.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _frontLeftEngineTrails_LL.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _frontLeftEngineTrails_LR.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _frontRightEngineTrails_LL.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //    _frontRightEngineTrails_LR.SetGradient("Color Over Life Gradiant", _VfxengineColorGradiant);
    //}

    private void VfxEngineLifeTime()
    {
        _VfxEngineCalcLTMult = Mathf.Abs(Mathf.Clamp(_VfxEngineLTMult * _thrust / 100f + 1f, 1f, 1.3f));
        Debug.Log(_VfxEngineCalcLTMult);
        _backLeftEngineTrails_LL.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _backLeftEngineTrails_LC.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _backLeftEngineTrails_LR.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _backRightEngineTrails_LL.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _backRightEngineTrails_LC.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _backRightEngineTrails_LR.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _frontLeftEngineTrails_LL.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _frontLeftEngineTrails_LR.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _frontRightEngineTrails_LL.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
        _frontRightEngineTrails_LR.SetFloat("Lifetime", _VfxEngineLifetime * _VfxEngineCalcLTMult);
    }

    private void VfxEngineSpawnRate()
    {
        _VfxEngineCalcSRMult = Mathf.Abs(Mathf.Clamp(_VfxEngineSRMult * _thrust / 100f + 1f, 1f, 2f));

        _backLeftEngineTrails_LL.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backLeftEngineTrails_LC.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backLeftEngineTrails_LR.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backRightEngineTrails_LL.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backRightEngineTrails_LC.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backRightEngineTrails_LR.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _frontLeftEngineTrails_LL.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _frontLeftEngineTrails_LR.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _frontRightEngineTrails_LL.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _frontRightEngineTrails_LR.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backLeftEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
        _backRightEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineSpawnRate * _VfxEngineCalcSRMult);
    }


    private void VfxEngineCircleSpawnRate()
    {
        _VfxEngineCircCalcSRMult = Mathf.Abs(Mathf.Clamp(_VfxEngineSRMult * _roll, 1f, 2f));


        _backLeftEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineCircleSpawnRate);
        if (_controls._moveInput.x > 0)
        {
        _backLeftEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineCircleSpawnRate * _VfxEngineCircCalcSRMult);
        }

        _backRightEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineCircleSpawnRate);
        if (_controls._moveInput.x < 0)
        {
        _backRightEngineTrails_C.SetFloat("Spawn Rate", _VfxEngineCircleSpawnRate * _VfxEngineCircCalcSRMult);
        }
    }

    private void ControlsUpdate()
    {
        //_thrust = _controls._moveInput.y * _controls._thrustForce;
        _thrust = _controls._thrust;
        _roll = _controls._moveInput.x * _controls._rollForce;
    }

    private void Update()
    {
        ControlsUpdate();
        VfxEngineTrailsVelocity();
        VfxEngineTrailsCircleVelocity();
        VfxEngineSpawnRate();
    }
}
