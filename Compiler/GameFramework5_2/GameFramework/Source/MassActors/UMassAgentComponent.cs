#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>There are two primary use cases for this component:</summary>
[CppInclude("MassAgentComponent.h")]
public partial class UMassAgentComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Registers the component with the owner effectively turning it on. Calling it multiple times won&#39;t break anything</summary>
	public  void Enable() {}
	///<summary>Registers the component with the owner effectively turning it off</summary>
	public  void Disable() {}
	///<summary>KillEntity</summary>
	public  void KillEntity(bool bDestroyActor) {}
	///<summary>OnRep_NetID</summary>
	public  void OnRep_NetID() {}
	///<summary>EntityConfig</summary>
	public FMassEntityConfig EntityConfig;
	///<summary>NetID</summary>
	public FMassNetworkID NetID;
	///<summary>bAutoRegisterInEditorMode</summary>
	public bool bAutoRegisterInEditorMode;
}
