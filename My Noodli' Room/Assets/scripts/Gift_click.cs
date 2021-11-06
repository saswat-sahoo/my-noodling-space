using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gift_click : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Image[] pops;
    private Image pop;


    // Update is called once per frame
    void OnMouseDown()
    {
        // this object was clicked - do something
        pop = pops[Random.Range(0, 5)];
        toggle();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pop != null)
            {
                pop.gameObject.SetActive(false);
            }
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
