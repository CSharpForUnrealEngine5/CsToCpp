#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/CheatManager.h")]
///<summary>A cheat manager extension can extend the main cheat manager in a modular way, being enabled or disabled when the system associated with the cheats is enabled or disabled</summary>
public partial class UCheatManagerExtension : UObject {
// CheatManagerExtension
	public UObject GetPlayerController() { return default; }
	public void AddedToCheatManager() {}
	public void RemovedFromCheatManager() {}
}
