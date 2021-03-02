using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahnedegis : MonoBehaviour
{
    
    public void sahne_degis(int sahne_id)
    {
        SceneManager.LoadScene(sahne_id);
    }

  
}
