namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fake connection that will absorb traffic and auto ack every packet. Useful for testing scaling. Use net.SimulateConnections command to add at runtime.</summary>
[CppInclude("Engine/NetConnection.h")]
public partial class USimulatedClientNetConnection : UNetConnection {
	public static UClass StaticClass() {return default;}
}
