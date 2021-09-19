using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLOSEUI : MonoBehaviour
{
    public GameObject UItohide;
    // Start is called before the first frame update
   public void hide()
    {
        UItohide.SetActive(false);
    }
}
