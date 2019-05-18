using SonicBloom.Koreo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour {
    
    public string eventID;      // 响应事件ID
    public float particlesPerBeat = 100;     // 速度

    private ParticleSystem particleSystemCom;

    // Use this for initialization
    void Start()
    {
        particleSystemCom = GetComponent<ParticleSystem>();
        Koreographer.Instance.RegisterForEvents(eventID, CreateParticle);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateParticle(KoreographyEvent koreographyEvent)
    {
        int particleCount = (int)(Koreographer.GetBeatTimeDelta() * particlesPerBeat);
        particleSystemCom.Emit(particleCount);
    }
}
