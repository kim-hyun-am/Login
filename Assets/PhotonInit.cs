using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Photon / PunBehaviour
public class PhotonInit : MonoBehaviour
{
    string m_reachabilitytext;
    //private void start()
    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            m_reachabilitytext = "not reachable.";
            //인터넷 연결이 안되었을 때 행동
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        {
               m_reachabilitytext = "reachable via carrier data network.";
            //데이터로 연결이 되었을 때 행동
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
               m_reachabilitytext = "reachable via local area network.";
            //와이파이로 연결이 되었을 때 행동
        }
    }
}
