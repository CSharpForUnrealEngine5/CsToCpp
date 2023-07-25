#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NUTActor.h")]
public partial class ANUTActor : AActor {
// NUTActor
	public FExecuteOnServer TempDelegate;
	public void Admin(string Command) {}
	public void ServerAdmin(string Command) {}
	public void UnitSeamlessTravel(string Dest/*=TEXT(" ")*/) {}
	public void UnitTravel(string Dest/*=TEXT(" ")*/) {}
	public void NetFlush() {}
	public void Wait(ushort Seconds) {}
	public void ServerClientStillAlive() {}
	public void ServerReceiveText(string InText) {}
	public void ServerClientPing() {}
	public void NetMulticastPing() {}
	public void ServerExecute(string InDelegate) {}
}
