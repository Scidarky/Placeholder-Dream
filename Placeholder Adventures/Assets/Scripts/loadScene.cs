using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    public string cenaParaCarr;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(cenaParaCarr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
