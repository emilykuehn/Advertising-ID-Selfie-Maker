using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDText : MonoBehaviour
{
    public Text myText = null;
    // Start is called before the first frame update


    public void Start()
            {
              myText.text = "I have always relied on the kindness of strangers.";
                Application.RequestAdvertisingIdentifierAsync(
                    (advertisingId, trackingEnabled, error) =>
                    {
                    //  Debug.Log(advertisingId.ToString());
                        if (trackingEnabled==false)
                        {error = "I have never relied on the kindness of strangers.";}
                        else{myText.text = advertisingId.ToString();}

                      //  return;
                        //myText.text = "I have never relied on the kindness of strangers.";
                    }
                );
            }


}
