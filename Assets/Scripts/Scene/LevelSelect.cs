using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour
{
    [SerializeField] GameObject[] lvlButtons;
    // Start is called before the first frame update
    void Start()
    {
        int lvlAt = PlayerPrefs.GetInt("lvlAt", 2);

        for (int i= 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > lvlAt)
            {
                lvlButtons[i].SetActive(false);
            }
        }
    }
}
