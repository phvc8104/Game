using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DamgePopUp : MonoBehaviour
{
    public static DamgePopUp current;
    public GameObject prefab;

    

    private void Awake()
    {
        current = this; 
        
        
    }
   

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            CreatePopUp(new Vector3(1,1,1), Random.Range(0, 1000).ToString(), Color.red);
        }
        
        

 
    }
    public void CreatePopUp(Vector3 position, string text, Color color)
    {
        var popup = Instantiate(prefab, position, Quaternion.identity);

        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.color = color;
        temp.text = text;
        Destroy(popup, 1f);
        Destroy(temp, 1f);
    }
}
