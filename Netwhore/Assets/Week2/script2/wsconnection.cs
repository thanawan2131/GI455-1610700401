using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;


namespace Programchatto
{
    
    public class wsconnection : MonoBehaviour
    {
        private WebSocket websocket;
        public InputField inputField;
        public Text SenderText;
        public Text RecieveText;


        List<string> MSG = new List<string>();
        
            void Start()
        {
            websocket = new WebSocket("ws://127.0.0.1:25500/");

            websocket.OnMessage += OnMessage;

            websocket.Connect();

            
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }


        public void OnDestroy()
        {
            if (websocket != null)
            {
                websocket.Close();
            }
        }

        public void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Debug.Log("msg from server : " + messageEventArgs.Data);
            MSG.Add(messageEventArgs.Data);
            string[] tempo = MSG[MSG.Count - 2].Split(':');
            RecieveText.text = (" " + MSG[0]); // for loop i = 0; i < MSG.Count; i++
           
        }

       public void SendOnClick()
        {

            websocket.Send("  " + inputField.text);
            SenderText.text = (" " + inputField.text); //swap 
        }



    }
}
    