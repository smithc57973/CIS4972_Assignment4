/*
 * Chris Smith
 * UIManager
 * Assignment 4
 * A script to manage UI elements.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text raceSelection;
    public Button dwarfButton;
    public Button elfButton;
    public Button humanButton;
    public Text classSelection;
    public Button clericButton;
    public Button fighterButton;
    public Button rogueButton;
    public Button wizardButton;
    public Text stats;
    public PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        raceSelection.enabled = false;
        dwarfButton.gameObject.SetActive(false);
        elfButton.gameObject.SetActive(false);
        humanButton.gameObject.SetActive(false);

        classSelection.enabled = false;
        clericButton.gameObject.SetActive(false);
        fighterButton.gameObject.SetActive(false);
        rogueButton.gameObject.SetActive(false);
        wizardButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        stats.text = pc.u.GetDescription() + "\nHP: " + pc.u.GetHP() + "\nDamage: " + pc.u.Attack();
    }
}
