using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canChooseRace;
    public bool canChooseClass;
    public bool doneChoosing;
    public UIManager ui; 
    public GameObject heroSpawn;
    public GameObject[] heros;
    public Unit u;

    // Start is called before the first frame update
    void Start()
    {
        canChooseRace = true;
        canChooseClass = false;
        doneChoosing = false;
        ui = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        heroSpawn = GameObject.FindGameObjectWithTag("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        if (canChooseRace)
        {
            ui.raceSelection.enabled = true;
            ui.dwarfButton.gameObject.SetActive(true);
            ui.elfButton.gameObject.SetActive(true);
            ui.humanButton.gameObject.SetActive(true);
        }

        if (canChooseClass && u.level < u.maxLevel)
        {
            doneChoosing = false;
            ui.classSelection.enabled = true;
            ui.clericButton.gameObject.SetActive(true);
            ui.fighterButton.gameObject.SetActive(true);
            ui.rogueButton.gameObject.SetActive(true);
            ui.wizardButton.gameObject.SetActive(true);
        }
        //Debug.Log(u.GetDescription() + " " + u.Attack() + " " + u.GetDmgType() + " " + u.GetLevel() + " " + u.GetHP());

    }

    public void ChooseRace(string choice)
    {
        switch (choice)
        {
            case "Dwarf":
                u = new Dwarf();
                Instantiate(heros[0], heroSpawn.transform);
                break;
            case "Elf":
                u = new Elf();
                Instantiate(heros[1], heroSpawn.transform);
                break;
            case "Human":
                u = new Human();
                Instantiate(heros[2], heroSpawn.transform);
                break;
            default:
                break;
        }
        canChooseRace = false;
        ui.raceSelection.enabled = false;
        ui.dwarfButton.gameObject.SetActive(false);
        ui.elfButton.gameObject.SetActive(false);
        ui.humanButton.gameObject.SetActive(false);
        canChooseClass = true;
    }

    public void ChooseClass(string choice)
    {
        switch (choice)
        {
            case "Cleric":
                u = new Cleric(u);
                break;
            case "Fighter":
                u = new Fighter(u);
                break;
            case "Rogue":
                u = new Rogue(u);
                break;
            case "Wizard":
                u = new Wizard(u);
                break;
            default:
                break;
        }
        canChooseClass = false;
        ui.classSelection.enabled = false;
        ui.clericButton.gameObject.SetActive(false);
        ui.fighterButton.gameObject.SetActive(false);
        ui.rogueButton.gameObject.SetActive(false);
        ui.wizardButton.gameObject.SetActive(false);
        doneChoosing = true;
    }
}
