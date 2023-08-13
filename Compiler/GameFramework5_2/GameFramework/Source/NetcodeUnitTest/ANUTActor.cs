namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NUTActor.h")]
public partial class ANUTActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>A delegate property, used solely for converting strings to delegates</summary>
	public FExecuteOnServer TempDelegate;
	///<summary>Executes a console command on the server</summary>
	public void Admin(string Command) {}
	///<summary>ServerAdmin</summary>
	public void ServerAdmin(string Command) {}
	///<summary>Triggers seamless travel</summary>
	public void UnitSeamlessTravel(string Dest/*=TEXT(" ")*/) {}
	///<summary>Triggers normal travel</summary>
	public void UnitTravel(string Dest/*=TEXT(" ")*/) {}
	///<summary>Flushes all pending net connection packets</summary>
	public void NetFlush() {}
	///<summary>Makes the game thread wait for the specified number of seconds</summary>
	public void Wait(ushort Seconds) {}
	///<summary>Notifies the server that the client is still around</summary>
	public void ServerClientStillAlive() {}
	///<summary>Test log function</summary>
	public void ServerReceiveText(FText InText) {}
	///<summary>Send a &#39;ping&#39; RPC to all clients, to make them log a ping, which unit tests then use to verify the presence of a client process</summary>
	public void ServerClientPing() {}
	///<summary>Received by all clients, emits a ping to log</summary>
	public void NetMulticastPing() {}
	///<summary>Takes a string representing a delegate (can&#39;t replicate delegate parameters), and executes that delegate on the server</summary>
	public void ServerExecute(string InDelegate) {}
}
