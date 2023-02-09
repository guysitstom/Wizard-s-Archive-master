using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ChemistryQuestion : MonoBehaviour
{
    [SerializeField] public SceneInfo sceneInfo;
    [SerializeField] public TextMeshProUGUI text;
    public bool isNextScene = true;
   
    public void Correct()
    {
        sceneInfo.isNextScene = isNextScene;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Incorrect()
    {
        text.text = "Incorrect: To find 1 Mole of a compound add up the atomic mass of all elements in the compound.";
    }


}
