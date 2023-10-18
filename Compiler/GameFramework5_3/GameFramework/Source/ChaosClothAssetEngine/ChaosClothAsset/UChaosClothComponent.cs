namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Chaos cloth component.</summary>
[CppInclude("ChaosClothAsset/ClothComponent.h")]
public partial class UChaosClothComponent : USkinnedMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Set the cloth asset used by this component.</summary>
	public void SetClothAsset(UChaosClothAsset InClothAsset) {}
	///<summary>Get the cloth asset used by this component.</summary>
	public UChaosClothAsset GetClothAsset() { return default; }
	///<summary>Reset the teleport mode.</summary>
	public void ResetTeleportMode() {}
	///<summary>Teleport the cloth particles to the new reference bone location keeping pose and velocities prior to advancing the simulation.</summary>
	public void ForceNextUpdateTeleport() {}
	///<summary>Teleport the cloth particles to the new reference bone location while reseting the pose and velocities prior to advancing the simulation.</summary>
	public void ForceNextUpdateTeleportAndReset() {}
	///<summary>Stop the simulation, and keep the cloth in its last pose.</summary>
	public void SuspendSimulation() {}
	///<summary>Resume a previously suspended simulation.</summary>
	public void ResumeSimulation() {}
	///<summary>Return whether or not the simulation is currently suspended.</summary>
	public bool IsSimulationSuspended() { return default; }
	///<summary>Set whether or not to enable simulation.</summary>
	public void SetEnableSimulation(bool bEnable) {}
	///<summary>Return whether or not the simulation is currently enabled.</summary>
	public bool IsSimulationEnabled() { return default; }
	///<summary>Reset all cloth simulation config properties to the values stored in the original cloth asset.</summary>
	public void ResetConfigProperties() {}
	///<summary>Hard reset the cloth simulation by recreating the proxy.</summary>
	public void RecreateClothSimulationProxy() {}
	///<summary>ClothAsset</summary>
	public UChaosClothAsset ClothAsset;
	///<summary>If enabled, and the parent is another Skinned Mesh Component (e.g. another Cloth Component, Poseable Mesh Component, Skeletal Mesh Component, ...etc.), use its pose.</summary>
	public bool bUseAttachedParentAsPoseComponent;
	///<summary>Whether to wait for the cloth simulation to end in the TickComponent instead of in the EndOfFrameUpdates.</summary>
	public bool bWaitForParallelTask;
	///<summary>Whether to enable the simulation or use the skinned pose instead.</summary>
	public bool bEnableSimulation;
	///<summary>Whether to suspend the simulation and use the last simulated pose.</summary>
	public bool bSuspendSimulation;
	///<summary>Whether to use the leader component pose.</summary>
	public bool bBindToLeaderComponent;
	///<summary>Whether to teleport the cloth prior to advancing the simulation.</summary>
	public bool bTeleport;
	///<summary>Whether to reset the pose, bTeleport must be true.</summary>
	public bool bReset;
	///<summary>Blend amount between the skinned (=0) and the simulated pose (=1).</summary>
	public float BlendWeight;
}
