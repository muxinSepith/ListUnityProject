using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TooltipUI : MonoBehaviour
{
    public Text OutlineText;
    public Text ContentText;

    //跟新显示
    public void UpdateTooltip(string text)
    {
        OutlineText.text = text;
        ContentText.text = text;
    }

    //显示
    public void Show()
    {
        gameObject.SetActive(true);
    }

    //隐藏
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void SetLocalPosition(Vector2 position)
    {
        transform.localPosition = position;
    }

}
