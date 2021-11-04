using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnadirMoneda : MonoBehaviour
{
    public Button addCoin;
    public Label coins;
    [HideInInspector] public int monedas;


    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        addCoin = root.Q<Button>("AddCoin");
        coins = root.Q<Label>("label-monedas");
        monedas = int.Parse(coins.text.Split(' ')[0]);

        addCoin.RegisterCallback<ClickEvent>(ev => addCoinToUI());
    }

    private void addCoinToUI()
    {
        monedas++;
        coins.text = $"{monedas} monedas";
    }
}