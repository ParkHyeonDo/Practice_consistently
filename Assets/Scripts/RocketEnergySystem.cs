using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class RocketEnergySystem : MonoBehaviour
{
    [SerializeField] public Image FuelImage;
    public float fuel = 100f;

    private void Update()
    {
        FuelImage.fillAmount += 0.001f * Time.deltaTime;
    }
}



