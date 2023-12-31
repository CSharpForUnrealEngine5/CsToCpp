namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for implementing a barebones/stripped-down game client, capable of connecting to a regular game server,</summary>
[CppInclude("MinimalClient.h")]
public partial class UMinimalClient : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Stores a reference to the created empty world, for execution and later cleanup</summary>
	public UWorld UnitWorld;
	///<summary>Stores a reference to the created unit test net driver, for execution and later cleanup</summary>
	public UNetDriver UnitNetDriver;
	///<summary>Stores a reference to the server connection</summary>
	public UNetConnection UnitConn;
}
