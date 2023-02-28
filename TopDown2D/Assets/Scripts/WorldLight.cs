using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace TimeSystem
{

    [RequireComponent(typeof(Light2D))]
    public class WorldLight : MonoBehaviour
    {
        private Light2D _light;

        [SerializeField]
        private Gradient _gradient;

        private void Awake()
        {
            _light = GetComponent<Light2D>();
            S_Time.OnDayPercentChange += SetLightingOverlay;
        }

        private void Destroy()
        {
            S_Time.OnDayPercentChange -= SetLightingOverlay;
        }

        private void SetLightingOverlay()
        {
            float midDayNormalized = S_Time.dayPercentage % 0.5f;
            float lowClampLimit = .1f;
            float highClampLimit = 1f;
            float midPoint = 0.5f;
            if (S_Time.dayPercentage == 0)
            {
                _light.intensity = lowClampLimit;
            }
            else if (S_Time.dayPercentage < midPoint)
            {
                _light.intensity = lowClampLimit + (midDayNormalized * ((highClampLimit - lowClampLimit) / midPoint));
                //_light.intensity = Mathf.Clamp(gunYarisiNormalized, lowClampLimit, highClampLimit);
            }
            else if (S_Time.dayPercentage == midPoint)
            {
                _light.intensity = highClampLimit;
            }
            else
            {
                _light.intensity = lowClampLimit + ((midPoint - midDayNormalized) * ((highClampLimit - lowClampLimit) / midPoint));

            }
            _light.color = _gradient.Evaluate(S_Time.dayPercentage);
        }
    }

}
