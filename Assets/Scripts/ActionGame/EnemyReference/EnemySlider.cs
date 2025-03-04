using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlider : MonoBehaviour
{
    public GirlHero girlHero;
    public SliderController sliderController;
    public Health _health;
    public SpriteRenderer sRend;

    public float heroDistance;

    void Start()
    {
        sliderController = SliderControllerManager.instance.sliderController.GetComponent<SliderController>();
        sRend = GetComponent<SpriteRenderer>();
        girlHero = PlayerManager.instance.girlHero;
        if (GetComponent<Health>() != null)
        {
            _health = GetComponent<Health>();
        }
        else
        {
            Debug.Log("It Should have Health");
        }
    }

    public void FixSlider()
    {
        sliderController.maxHealth = _health.maxHealth;
        sliderController.health = _health.currentHealth;
        sliderController.sprite = sRend.sprite;
    }
}
