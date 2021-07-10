
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;

namespace Network
{
    public class StartMenuBehavior : MonoBehaviour
    { /**
        public Transform playerPrefab;
        public Transform observerPrefab;
        public GameObject player;
        public GameObject observer;
    	*/

        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(10, 10, 300, 300));
            if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
            {
                StartButtons();
            }
            else
            {
                StatusLabels();

                SubmitNewPosition();
            }

            GUILayout.EndArea();
        }

        static void StartButtons()
        {
            if (GUILayout.Button("Host")) 
            {
                NetworkManager.Singleton.StartHost();
                Debug.Log("is Host and Server");
                GameObject.Find("PlayerSpawner").GetComponent<Spawner>().InitializePlayer();
                //player = Instantiate(playerPrefab, new Vector3(0, 1, 0), Quaternion.identity).gameObject;
                //player.GetComponent<NetworkObject>().SpawnAsPlayerObject(NetworkManager.Singleton.LocalClientId, null, true);
            }
            if (GUILayout.Button("Client")) 
            {
                NetworkManager.Singleton.StartClient();
                Debug.Log("is Client");
                GameObject.Find("PlayerSpawner").GetComponent<Spawner>().InitializePlayer();
                //Debug.Log(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
               
                //SpawnServerRpc(NetworkManager.Singleton.LocalClientId);
            } 
        }
        /**
        [ServerRpc]
        public void SpawnServerRpc(ulong clientId)
        {
            observer = Instantiate(observerPrefab, new Vector3(800, 530, 300), Quaternion.identity).gameObject;
            observer.GetComponent<NetworkObject>().SpawnAsPlayerObject(clientId, null, true);
        }*/

        static void StatusLabels()
        {
            var mode = NetworkManager.Singleton.IsHost ?
                "Host" : NetworkManager.Singleton.IsServer ? "Server" : "Client";

            GUILayout.Label("Transport: " +
                NetworkManager.Singleton.NetworkConfig.NetworkTransport.GetType().Name);
            GUILayout.Label("Mode: " + mode);
            LogClientsSetup ();
        }

        static void SubmitNewPosition()
        {
            if (GUILayout.Button(NetworkManager.Singleton.IsServer ? "Move" : "Request Position Change"))
            {
                if (NetworkManager.Singleton.ConnectedClients.TryGetValue(NetworkManager.Singleton.LocalClientId,
                    out var networkedClient))
                {
                    var player = networkedClient.PlayerObject.GetComponent<NetworkPlayer>();
                    if (player)
                    {
                        player.Move();
                    }
                }
            }
        }

        static void LogClientsSetup () {
            if (GUILayout.Button("Show Connected Clients")) {
                GameObject.Find("PlayerSpawner").GetComponent<Spawner>().LogClients();
            }
        }
    }
}