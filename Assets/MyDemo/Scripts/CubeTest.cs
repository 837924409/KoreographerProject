using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using System;

public class CubeTest : MonoBehaviour {

    public string eventID;      // 响应事件ID

    public float minScale = 0.5f;
    public float maxScale = 1.5f;

    void Start () {
        Koreographer.Instance.RegisterForEventsWithTime(eventID, ChangeCube);

    }

    private void ChangeCube(KoreographyEvent koreoEvent, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
    {
        if (koreoEvent.HasCurvePayload()) {
            float curveValue = koreoEvent.GetValueOfCurveAtTime(sampleTime);
            transform.localScale = Vector3.one * Mathf.Lerp(minScale, maxScale, curveValue);
        }
    }
}
