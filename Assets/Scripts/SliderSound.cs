using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderSound : MonoBehaviour
{
    private const float MultiplireVolume = 20;

    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Slider _slider;
    [SerializeField] private string _titleMixerParameter;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        _audioMixer.audioMixer.SetFloat(_titleMixerParameter, Mathf.Log10(volume) * MultiplireVolume);
    }
}