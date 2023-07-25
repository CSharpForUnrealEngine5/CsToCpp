#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassAgentComponent.h")]
///<summary>There are two primary use cases for this component:</summary>
public partial class UMassAgentComponent : UActorComponent {
// MassAgentComponent
	public void Enable() {}
	public void Disable() {}
	public void KillEntity(bool bDestroyActor) {}
	public void OnRep_NetID() {}
	public FMassEntityConfig EntityConfig;
	public FMassNetworkID NetID;
	public bool bAutoRegisterInEditorMode;
}
