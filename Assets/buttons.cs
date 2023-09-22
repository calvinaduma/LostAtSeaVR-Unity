using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    const int SIZE = 44;
    string[] names = {"Andromeda", "Antlia", "Apus", "Aquarius", "Aquila", "Ara", "Aries", "Auriga", "Bootes", "Caelum",
                      "Camelopardalis", "Cancer", "Canes_Venatici", "Canis_Major", "Canis_Minor", "Capricornus", "Carina",
                      "Cassiopeia", "Centaurus", "Cepheus", "Cetus", "Chamaeleon", "Circinus", "Columba", "Coma_Berenices", "Corona_Australis",
                      "Corona_Borealis", "Corvus", "Crater", "Crux", "Cygnus", "Delphinus", "Dorado", "Draco", "Equuleus", "Eridanus", "Fornax",
                      "Gemini", "Grus", "Hercules", "Horologium", "Hydra", "Hydrus", "Indus"};
    GameObject buttonLeft, buttonRight;
    GameObject[] constellations = new GameObject[SIZE];
    bool pressed = false, pressedR = false;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        buttonLeft = GameObject.Find("ButtonL");
        buttonRight = GameObject.Find("ButtonR");
        for(int i=1; i<=SIZE; i++)
        {
            string str = i.ToString();
            if (i < 10)
                str = "0" + str;
            string curr = str + "_" + names[i-1];
            constellations[i-1] = GameObject.Find(curr);
            if (i != 1)
                constellations[i-1].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonLeft.transform.position.x < 3.723)
        {
            buttonLeft.transform.position = new Vector3(3.723f, buttonLeft.transform.position.y, buttonLeft.transform.position.z);
            if (!pressed)
                leftButton();
            pressed = true;
        }
        else if (buttonLeft.transform.position.x >= 3.723 && buttonLeft.transform.position.x < 3.86)
        {
            buttonLeft.transform.position = buttonLeft.transform.position + new Vector3(.01f, 0, 0);
            if (buttonLeft.transform.position.x > 3.8)
                pressed = false;
        }
        else if (buttonLeft.transform.position.x > 3.86)
            buttonLeft.transform.position = new Vector3(3.86f, buttonLeft.transform.position.y, buttonLeft.transform.position.z);
        if (buttonRight.transform.position.x > 6.51)
        {
            buttonRight.transform.position = new Vector3(6.505f, buttonRight.transform.position.y, buttonRight.transform.position.z);
            if (!pressedR)
                rightButton();
            pressedR = true;
        }
        else if (buttonRight.transform.position.x <= 6.52 && buttonRight.transform.position.x > 6.4)
        {
            buttonRight.transform.position = buttonRight.transform.position + new Vector3(-.01f, 0, 0);
            if (buttonRight.transform.position.x < 6.43)
                pressedR = false;
        }else if (buttonRight.transform.position.x < 6.4)
            buttonRight.transform.position = new Vector3(6.4f, buttonRight.transform.position.y, buttonRight.transform.position.z);

    }

    void leftButton()
    {
        if (index > 0)
        {
            constellations[index].SetActive(false);
            index--;
            constellations[index].SetActive(true);
            
        }
    }

    void rightButton()
    {
        if (index < SIZE-1)
        {
            constellations[index].SetActive(false);
            index++;
            constellations[index].SetActive(true);

        }
    }
}
