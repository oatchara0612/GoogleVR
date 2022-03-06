using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
  public void getAnimatorDencing()
    {
        this.GetComponent<Animator>().Play("Defeated");
    }
  public void getAnimatorRumba()
    {
        this.GetComponent<Animator>().Play("Twist Dance");
    }
}
