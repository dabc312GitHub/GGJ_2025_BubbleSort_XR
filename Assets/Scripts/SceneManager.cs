using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject prefabGrabBubble;
    public GameObject prefabContainerBubble;
    [HideInInspector] public int level = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectLevel(int levelIni)
    {
        level = levelIni;
    }

    void RandomCreator()
    {
        
    }
}
