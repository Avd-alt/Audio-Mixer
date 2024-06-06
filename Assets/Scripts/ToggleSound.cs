using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleSound : MonoBehaviour
{
    private const string MasterVolume = nameof(MasterVolume);

    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Toggle _toggle;

    private float _minSoundVolume = -80;
    private float _maxSoundVolume = 0;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToogleMusic);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToogleMusic);
    }

    private void ToogleMusic(bool enabled)
    {
        if (enabled)
            _audioMixer.audioMixer.SetFloat(MasterVolume, _maxSoundVolume);
        else
            _audioMixer.audioMixer.SetFloat(MasterVolume, _minSoundVolume);
    }
}