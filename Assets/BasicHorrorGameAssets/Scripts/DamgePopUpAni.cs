using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamgePopUpAni : MonoBehaviour
{
    public AnimationCurve opacity;
    public AnimationCurve scale;
    private TextMeshProUGUI tmp;
    public float time = 0;

    private void Awake()
    {
        tmp = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

    }
    private void Update()
    {
        tmp.color = new Color(1, 1, 1, opacity.Evaluate(time));
        transform.localScale = Vector3.one * scale.Evaluate(time);
        time += Time.deltaTime;
    }
}
