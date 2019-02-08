using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour {

    public string versionName = "0.1";
    public GameObject sectionView1, sectionView2, sectionView3;


    public void connectToPhoton() {
 
        PhotonNetwork.ConnectUsingSettings (versionName);

        Debug.Log ("Photon Home");

    }
    private void OnConnectedToMaster() {
        PhotonNetwork.JoinLobby  (TypedLobby.Default);

        Debug.Log ("We are connected to the Master");

    }
    private void OnJoinedLobby() {
        sectionView1.SetActive (true);
        sectionView2.SetActive (true);

        Debug.Log ("On Joined Lobby");
    }
   
   

    private void OnDisconnectedFromPhoton(){

        if (sectionView1.active)
            sectionView1.SetActive(false);
        if (sectionView2.active)
            sectionView2.SetActive(false);

        sectionView3.SetActive(true);

        Debug.Log ("Disconnect from Photon services");

    }
    
    
}
