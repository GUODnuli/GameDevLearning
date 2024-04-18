using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adaptor
{
    public class AdaptorMain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Adaptor adaptor = new Adaptor();
            adaptor.Connect(AdaptorType.Android);
            adaptor.Connect(AdaptorType.IOS);
            adaptor.Connect(AdaptorType.None);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}