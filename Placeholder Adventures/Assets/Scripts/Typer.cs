using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Typer : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    private AudioSource _audioSource;
    private string OGMessage;
    public bool print;
    public float letterTime = 0.08f;

    private void Awake()
    {
        TryGetComponent(out textComponent);
        TryGetComponent(out _audioSource);
        OGMessage = textComponent.text;
        textComponent.text = "";
    }

    private void OnEnable()
    {
        printMsg(OGMessage);
    }

    private void OnDisable()
    {
        textComponent.text = OGMessage;
        StopAllCoroutines();
    }

    public void printMsg(string msg)
    {
        if (gameObject.activeInHierarchy)
        {
            if (print) return;
            print = true;
            StartCoroutine(LetraporLetra(msg));
        }
    }

    IEnumerator LetraporLetra(string msg)
    {
        string mess = "";
        foreach (var letra in msg)
        {
            mess += letra;
            textComponent.text = mess;
            _audioSource.Play();    
            yield return new WaitForSeconds(letterTime);
        }

        print = false;
        StopAllCoroutines();
    }
}


