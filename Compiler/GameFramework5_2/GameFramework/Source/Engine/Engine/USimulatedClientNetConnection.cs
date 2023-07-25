#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetConnection.h")]
///<summary>A fake connection that will absorb traffic and auto ack every packet. Useful for testing scaling. Use net.SimulateConnections command to add at runtime.</summary>
public partial class USimulatedClientNetConnection : UNetConnection {
// SimulatedClientNetConnection
}
