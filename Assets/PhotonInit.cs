using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class PhotonInit : PunBehaviour
{
    string m_ReachabilityText;
    private void Start()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            m_ReachabilityText = "Not Reachable.";
            // 인터넷 연결이 안되었을 때 행동
        }
        else if(Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        {
            m_ReachabilityText = "Reachable via carrier data network.";
            // 데이터로 연결이 되었을 때 행동
        }
        else if(Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            m_ReachabilityText = "Reachable via Local Area Network.";
            // 와이파이로 연결이 되었을 때 행동
        }
    }
}
