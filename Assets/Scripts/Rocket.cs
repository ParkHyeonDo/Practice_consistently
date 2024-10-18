using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;

    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    private float duration = 1f;
    RocketEnergySystem EnergySystem;
    

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        EnergySystem = GetComponent<RocketEnergySystem>();
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
    }

    private void Update()
    {
        duration += Time.deltaTime;
    }

    public void Shoot()
    {
        if ( duration >1f) 
        {
            if (EnergySystem.fuel >= FUELPERSHOOT)
            {
                duration = 0f;
                EnergySystem.fuel -= FUELPERSHOOT;
                _rb2d.gravityScale = 1;
                _rb2d.AddForce(transform.up * SPEED, ForceMode2D.Impulse);
                EnergySystem.FuelImage.fillAmount -= FUELPERSHOOT / 100;
            }
        }
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
    }

}
