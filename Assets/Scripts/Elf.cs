﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();
    GameObject helloCard;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        GridRow.Add(A);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void SayHello()
    {
        helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
        SoundManager.playSound(SoundManager.elfHello);
    }

    private void SetGridParent(GameObject block)
    {
        block.transform.SetParent(GridRow[0], false);
    }

    public void Exercise01()
    {
        SoundManager.playSound(SoundManager.effectCorrect);
        spriteRenderer.flipX = true;
    }

    private void Update()
    {
        if (CharacterController.playerDirectionInt == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (CharacterController.playerDirectionInt == 1)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
        else if (CharacterController.playerDirectionInt == 2)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else if (CharacterController.playerDirectionInt == 3)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }
    }

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.elfHey);
    }
}
