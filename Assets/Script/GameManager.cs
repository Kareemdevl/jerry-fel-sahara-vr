using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    public void CompleteLevel()

    {
        // Debug.Log("Level Won");
        CompleteLevelUI.SetActive(true);
    }
}

