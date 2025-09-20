Libs/Server/.gitkeep
Libs/Client/.gitkeep
Resources/Server/Scripts/MainServer.cs
Resources/Server/Assets/.gitkeep
using RageCoop.Server.Scripting;
using RageCoop.Core;

namespace GTA offline 
{
    public class MainServer : ServerScript
    {
        public override void OnStart()
        {
            API.Log("Server script started!");
            // Initialize your server-side logic here
        }

        public override void OnStop()
        {
            API.Log("Server script stopped.");
            // Clean up resources here
        }
    }
}
