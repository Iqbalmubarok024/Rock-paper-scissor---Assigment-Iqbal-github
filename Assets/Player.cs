using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Character selectedCharacter;
    [SerializeField] List<Character> characterList;

    public Character SelectedCharacter { get => selectedCharacter; }

    public void prepare()
    {
        selectedCharacter = null;
    }

    public void SelectedCharacter(Character character)
    {
        selectedCharacter = character;
    }

    public void SetPlay(bool value)
    {
        foreach (var character in characterList)
        {
            character.Button.interactable = value;
        }

    }
}
