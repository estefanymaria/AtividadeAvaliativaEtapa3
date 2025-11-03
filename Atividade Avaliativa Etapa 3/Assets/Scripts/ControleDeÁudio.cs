using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class ControleDeÁudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;

    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;

    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;
    }

    void Update()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "LIGADO";
            textoMusica.color = Color.green;
        }
        else
        {
            textoMusica.text = "DESLIGADO";
            textoMusica.color = Color.red;
        }
    }
}