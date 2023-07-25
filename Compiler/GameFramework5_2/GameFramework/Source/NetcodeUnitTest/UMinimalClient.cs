#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MinimalClient.h")]
///<summary>Base class for implementing a barebones/stripped-down game client, capable of connecting to a regular game server,</summary>
public partial class UMinimalClient : UObject {
// MinimalClient
	public UWorld UnitWorld;
	public UNetDriver UnitNetDriver;
	public UNetConnection UnitConn;
}
