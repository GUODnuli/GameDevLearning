using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adaptor
{
    public enum AdaptorType
    {
        None,
        Android,
        IOS
    }
    public interface Iwire
    {
        void Connect(AdaptorType adaptorType);
    }

    public class Adaptor: Iwire
    {
        AndroidWire androidWire = new();
        IOSWire iosWire = new();

        public void Connect(AdaptorType adaptorType)
        {
            switch (adaptorType)
            {
                case AdaptorType.Android:
                    androidWire.AndroidConnect();
                    break;
                case AdaptorType.IOS:
                    iosWire.IOSConnect();
                    break;
                default:
                    Debug.Log("No Adaptor Found");
                    break;
            }
        }
    }
}