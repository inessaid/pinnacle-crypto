using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UStellar.Examples
{
    
    public class Menu : MonoBehaviour
    {
        
        public InputField mykey;
        public List<Example> examples = new List<Example>()
        {
            new CreateAccount(),
            new SendXLM()
        };

        private Example currentExample;

        public void Awake()
        {
            UStellar.Core.UStellarManager.SetStellarTestNetwork();
            UStellar.Core.UStellarManager.Init();
        }

        public void OnClickExample(int id)
        {
            if (PlayerPrefs.GetString("public") == "null")
            {
                PlayerPrefs.SetString("public", mykey.text);
            }
            OpenExample(id);
        }

        private void OpenExample(int id)
        {
            for (int i = 0; i < examples.Count; i++)
            {
                if (examples[i].id == id)
                {
                    currentExample = examples[i];
                    currentExample.Open();
                    break;
                }
            }
        }
    }
}
