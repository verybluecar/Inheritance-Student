using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpeedPickUp : PickUp
{
    public ParticleSystem SpeedParticle;
    public float SpeedIncrease;
    public float normalSpeed;
    private SpriteRenderer SpriteRenderer;
    private BoxCollider2D SpeedCollider;
    
    public void Start()
    {
       
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpeedCollider = GetComponent<BoxCollider2D>();
    }
    public override void ActivatePickUp()
    {
        SpeedParticle.gameObject.SetActive(true);
        player.moveSpeed += SpeedIncrease;
        SpriteRenderer.enabled = false;
        SpeedCollider.enabled = false;
        StartCoroutine(LilTimer());
       

    }

    private IEnumerator LilTimer()
    {
        Debug.Log("timerStarted");
        yield return new WaitForSeconds(8f);
        SpeedParticle.gameObject.SetActive(false);
        player.moveSpeed = normalSpeed;
        Destroy(gameObject);
    }
}

