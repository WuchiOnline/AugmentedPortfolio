using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Pixelplacement;

public class AP_InterfaceAnimations : MonoBehaviour
{
    public bool isTextParent;
    public TMP_Text text;
    public Renderer rend;

    //private void Awake()
    //{
    //    text = text.GetComponent<TMP_Text>();
    //}

    private void Start()
    {
        if(isTextParent)
        {
            FadeInText(Color.white);
            TranslateLocalPosition(Vector3.up * 1.55f, 1f, 0f, Tween.EaseBounce, false);
        }
        else
        {
            rend = GetComponent<Renderer>();
            FadeInRenderer(new Color (0,0,0, .4f));
        }
    }

    public void FadeInText(Color targetColor)
    {
        Color invisColor = new Color(0, 0, 0, 0);
        Tween.Value(invisColor, targetColor, HandleTextColorChange, 1f, 0f, Tween.EaseLinear, Tween.LoopType.None, null, null, true);
    }

    public void FadeInRenderer(Color targetColor)
    {
        Color invisColor = new Color(0, 0, 0, 0);
        Tween.Value(invisColor, targetColor, HandleRendererColorChange, 1f, 0f, Tween.EaseLinear, Tween.LoopType.None, null, null, true);
    }

    public void HandleTextColorChange(Color val)
    {
        text.color = val;
    }

    public void HandleRendererColorChange(Color val)
    {
        rend.material.color = val;
    }

    public void TranslateLocalPosition(Vector3 targetPosition, float duration, float delay, AnimationCurve easeCurve, bool isLooping)
    {
        if (!isLooping)
        {
            Tween.LocalPosition(transform, targetPosition, duration, delay, easeCurve, Tween.LoopType.None, null, null, true);
        }
        else
        {
            Tween.LocalPosition(transform, targetPosition, duration, delay, easeCurve, Tween.LoopType.Loop, null, null, true);
        }
    }

}