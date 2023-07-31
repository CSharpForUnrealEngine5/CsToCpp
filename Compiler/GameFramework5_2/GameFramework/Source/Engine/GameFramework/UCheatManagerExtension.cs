#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A cheat manager extension can extend the main cheat manager in a modular way, being enabled or disabled when the system associated with the cheats is enabled or disabled</summary>
[CppInclude("GameFramework/CheatManager.h")]
public partial class UCheatManagerExtension : UObject {
	///<summary>GetPlayerController</summary>
	public  APlayerController GetPlayerController() { return default; }
	///<summary>AddedToCheatManager</summary>
	public  void AddedToCheatManager() {}
	///<summary>RemovedFromCheatManager</summary>
	public  void RemovedFromCheatManager() {}
}
