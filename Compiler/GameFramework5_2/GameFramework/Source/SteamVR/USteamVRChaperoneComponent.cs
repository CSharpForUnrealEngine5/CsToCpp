#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRChaperoneComponent.h")]
///<summary>SteamVR Extensions Function Library</summary>
public partial class USteamVRChaperoneComponent : UActorComponent {
// SteamVRChaperoneComponent
	public void FSteamVRChaperoneEvent() {}
	public FSteamVRChaperoneEvent OnLeaveBounds;
	public FSteamVRChaperoneEvent OnReturnToBounds;
	public TArray<FVector> GetBounds() { return default; }
}
