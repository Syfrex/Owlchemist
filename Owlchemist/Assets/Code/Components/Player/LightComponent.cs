using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightComponent : BaseComponent
{
    public bool startLit = false;

    public int maxCharges = 3;

    public int currentCharges { get; set; }

    public Light lightSource;
    public GameObject flames;
    public ParticleSystem fizzleSystem;
    public float lightIntensity;
    public float maxFuel = 100f;
    public float currentFuelDecay { get; set; }
    public float fuelDecay = 10f;
    public float runningFuelDecay = 6f;
    public float increasedFuelDecay = 30f;

    public float maxIntensity = 2f;
    public float minIntensity = .5f;

    AudioSource source;
    public AudioClip activetorchSoundLoop;
    private ParticleSystem flameSystem;

    public List<Light> nearbyLights = new List<Light>();

    public float currentFuel;

    private void Awake()
    {
        lightSource.enabled = startLit;

        flames.SetActive(true);

        lightIntensity = lightSource.intensity;
        currentFuel = 0;

        source = GetComponent<AudioSource>();
        source.clip = activetorchSoundLoop;
        source.loop = true;
        source.Play();

        currentCharges = maxCharges;
        flameSystem = flames.GetComponent<ParticleSystem>();

        currentCharges = 0;
    }

    public void Reset()
    {
        currentFuel = maxFuel;
    }

    public bool IsLightEnabled()
    {
        return lightSource.enabled;
    }

    public void PlayFizzle()
    {
        fizzleSystem.Play();
    }

    public void SetLightEnabled(bool value)
    {
        lightSource.enabled = value;

        if (value)
        {
            flameSystem.Play();
            source.Play();
        }
        else
        {
            flameSystem.Stop();
            source.Stop();
        }
    }
}
