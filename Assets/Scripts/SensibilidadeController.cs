using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensibilidadeController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    public void ChangeMouseSensi(Slider slider)
    {
        playerController.SetSensibilidade(slider.value);
    }
}
