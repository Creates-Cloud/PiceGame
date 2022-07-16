using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiceFowwedScripts : MonoBehaviour
{
    public const int Upwalk = 0;
    public const int DownWalk = 1;
    public const int LeftWalk = 2;
    public const int RightWalk = 3;
    public int _state = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputkey();
        switch(_state)
        {
            case Upwalk:
            {
               this.GetComponent<Animator>().SetInteger("state", Upwalk);
               break;
            }
            case LeftWalk:
            {
                this.GetComponent<Animator>().SetInteger("state",LeftWalk);
                break;
            }
             

        }
    }
    public void Inputkey()
    {

    }
}
