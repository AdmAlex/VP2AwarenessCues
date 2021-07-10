
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using MLAPI.Connection;
using UnityEngine;


namespace Network
{
    public class Spawner : NetworkBehaviour
    {
        public Transform playerPrefab;
        public Transform observerPrefab;
        public GameObject player;
        public GameObject observer;

        public void InitializePlayer() 
        {   
            

            if (NetworkManager.Singleton.IsHost) {
                Debug.Log("is Host and server in Spawner");
                Debug.Log("HostId: " + NetworkManager.Singleton.LocalClientId);
                //Debug.Log("PlayerObject: " + NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                player = Instantiate(playerPrefab, new Vector3(0, 1, 0), Quaternion.identity).gameObject;
                player.GetComponent<NetworkObject>().SpawnAsPlayerObject(NetworkManager.Singleton.LocalClientId, null, true);
                Debug.Log(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
               

            } 
            else 
            {
                Debug.Log("is Client in Spawner");
                //Debug.Log(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                Debug.Log("ClientId: " + NetworkManager.Singleton.LocalClientId);
                ulong id = (ulong)2;
                SpawnServerRpc(id);
                Debug.Log("isspawning");
            }
        }

        public void LogClients() {
            Debug.Log("Number of connected Clients: " + NetworkManager.Singleton.ConnectedClients.Count);
            foreach (var entry in NetworkManager.Singleton.ConnectedClients) {
                Debug.Log("---------- Clients ----------");
                Debug.Log("key: " + entry.Key);
                NetworkClient client = entry.Value;
                Debug.Log("Client: " + client);
                Debug.Log("PlayerObject: " + client.PlayerObject);
                Debug.Log("Owned Objects: " + client.OwnedObjects.Count);
                Debug.Log("---------- Clients ----------");
            }
        }

        [ServerRpc]
        public void SpawnServerRpc(ulong clientId)
        {
            //Debug.Log("inRPC: ");
            //Debug.Log("inRPC: " + observerPrefab);
            //new Vector3(800, 500, -295)
            observer = Instantiate(observerPrefab, new Vector3(3, 1, 3), Quaternion.identity).gameObject;
            Debug.Log("networkobject: " + observer.GetComponent<NetworkObject>());
            observer.GetComponent<NetworkObject>().SpawnAsPlayerObject(clientId, null, true);
            Debug.Log(NetworkManager.Singleton.ConnectedClients[clientId].PlayerObject);
        }
    }
}
