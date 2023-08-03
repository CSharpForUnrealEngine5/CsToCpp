#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom behaviour for Set Asset By Path</summary>
[CppInclude("Behaviour/Builtin/Path/RCSetAssetByPathBehaviour.h")]
public partial class URCSetAssetByPathBehaviour : URCBehaviour {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to property container</summary>
	public URCVirtualPropertyContainerBase PropertyInContainer;
	///<summary>Pointer to the current Class the Asset will use to set the Targeted Exposed Object.</summary>
	public UClass AssetClass;
	///<summary>Struct holding the Path Information to help load Assets.</summary>
	public FRCSetAssetPath PathStruct;
	///<summary>Bool used to help tell if the path given is an internal or external one.</summary>
	public bool bInternal;
	///<summary>Targeted Property Id</summary>
	public FGuid TargetEntityId;
}
