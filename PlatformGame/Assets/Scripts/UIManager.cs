using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image whiteEffectImage;
    private int effectControl = 0;
    public IEnumerator WhiteEffect()
    {
        whiteEffectImage.gameObject.SetActive(true);
        while (effectControl==0)
        {
            yield return new WaitForSeconds(0.001f);
            whiteEffectImage.color += new Color(0, 0, 0, 0.1f);
            if(whiteEffectImage.color==new Color(whiteEffectImage.color.r, whiteEffectImage.color.g, whiteEffectImage.color.b,1))
            {
                effectControl = 1;
            }
        }
        while (effectControl == 1)
        {
            yield return new WaitForSeconds(0.001f);
            whiteEffectImage.color += new Color(0, 0, 0, -0.1f);
            if(whiteEffectImage.color== new Color(whiteEffectImage.color.r, whiteEffectImage.color.g, whiteEffectImage.color.b, 0))
            {
                effectControl = 2;
            }
        }
        if (effectControl == 2)
        {
            Debug.Log("Efekt bitti");
        }
    }
}
