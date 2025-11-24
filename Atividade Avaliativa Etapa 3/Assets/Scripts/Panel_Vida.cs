using UnityEngine;
using UnityEngine.UI;


public class Panel_Vida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    
    public Personagem personagem;
    [SerializeField] private int vidasRestantes;

    void Start()
    {
        if (personagem != null & sliderVidasRestantes != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = personagem.getVida();
        }
    }

    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = personagem.getVida();
            sliderVidasRestantes.value = vidasRestantes;
        }
    }
}