using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pop_up_click : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Image pop;
   
    

    // Update is called once per frame
    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log(this.name);
        toggle();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pop.gameObject.SetActive(false);
        }
    }
    private void toggle()
    {
        if (!pop.gameObject.activeSelf)
        {
            pop.gameObject.SetActive(true);
        }
        
    }
}
