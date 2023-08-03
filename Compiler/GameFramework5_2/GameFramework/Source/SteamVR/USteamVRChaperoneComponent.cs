#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SteamVR Extensions Function Library</summary>
[CppInclude("SteamVRChaperoneComponent.h")]
public partial class USteamVRChaperoneComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FSteamVRChaperoneEvent</summary>
	public  void FSteamVRChaperoneEvent() {}
	///<summary>OnLeaveBounds</summary>
	public FSteamVRChaperoneEvent OnLeaveBounds;
	///<summary>OnReturnToBounds</summary>
	public FSteamVRChaperoneEvent OnReturnToBounds;
	///<summary>Returns the bounds from the Chaperone, in Unreal-scale HMD-space coordinates, centered around the HMD&#39;s calibration origin (0,0,0).  Each set of four bounds will form a quad to define a set of bounds</summary>
	public  TArray<FVector> GetBounds() { return default; }
}
