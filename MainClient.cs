Libs/Client/.gitkeep
Resources/Client/.gitkeep
Resources/Client/Scripts/.gitkeep
Resources/Client/Assets/.gitkeep
using RageCoop.Client.Scripting;
using RageCoop.Core;
using GTA; // ScriptHookVDotNet namespace

namespace GTA offline 
{
    public class MainClient : ClientScript
    {
        public override void OnStart()
        {
            API.Log("Client script started!");
            // Initialize client-side logic here
        }

        public override void OnStop()
        {
            API.Log("Client script stopped.");
            // Clean up resources here
        }
    }
}
