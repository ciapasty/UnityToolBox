using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public float shakeMagnitude = 0.2f;
    public float dampingSpeed = 2.0f;

    private float shakeDuration = 0f;
    Vector3 initialPosition;

    void OnEnable() {
        initialPosition = transform.localPosition;
    }

    void Update() {
        if (shakeDuration > 0) {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        } else {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void TriggerShake(float duration) {
        shakeDuration = duration;
    }
}
