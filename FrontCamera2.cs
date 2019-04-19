using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontCamera2 : MonoBehaviour
{
  private bool camAvailable;
  public WebCamTexture frontCam;
  private Texture defaultBackground;

  //public RawImage background;
    // Start is called before the first frame update
    private void Start()
    {

        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {
          Debug.Log("no camera");
          camAvailable = false;
          return;
        }

        for(int i = 0; i <devices.Length; i++)
        {
          if (devices[i].isFrontFacing)
          {
            frontCam = new WebCamTexture(devices[i].name);
          }
        }
        if (frontCam == null)
        {
          Debug.Log("can't find front camera");
          return;
        }

        frontCam.Play();
        GetComponent<Renderer>().material.mainTexture = frontCam;
        int rotAngle = frontCam.videoRotationAngle;
        camAvailable = true;
    }
    private void Update()
    {


      if (!camAvailable)
      return;
    }
}
