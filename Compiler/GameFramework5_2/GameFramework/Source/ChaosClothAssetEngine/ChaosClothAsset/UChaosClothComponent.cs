#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothComponent.h")]
///<summary>Chaos cloth simulation component.</summary>
public partial class UChaosClothComponent : USkinnedMeshComponent {
// ChaosClothComponent
	public  void SetClothAsset(UChaosClothAsset InClothAsset) {}
	public  UChaosClothAsset GetClothAsset() { return default; }
	public  void ResetTeleportMode() {}
	public  void ForceNextUpdateTeleport() {}
	public  void ForceNextUpdateTeleportAndReset() {}
	public  void SuspendSimulation() {}
	public  void ResumeSimulation() {}
	public  bool IsSimulationSuspended() { return default; }
	public UChaosClothAsset ClothAsset;
	public bool bUseAttachedParentAsPoseComponent;
	public bool bWaitForParallelTask;
	public bool bDisableSimulation;
	public bool bSuspendSimulation;
	public bool bBindToLeaderComponent;
	public bool bTeleport;
	public bool bReset;
	public float BlendWeight;
}
