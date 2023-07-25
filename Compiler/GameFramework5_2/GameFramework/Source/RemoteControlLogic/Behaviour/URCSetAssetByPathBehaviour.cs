#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Behaviour/Builtin/Path/RCSetAssetByPathBehaviour.h")]
///<summary>Custom behaviour for Set Asset By Path</summary>
public partial class URCSetAssetByPathBehaviour : URCBehaviour {
// RCSetAssetByPathBehaviour
	public URCVirtualPropertyContainerBase PropertyInContainer;
	public UClass AssetClass;
	public FRCSetAssetPath PathStruct;
	public bool bInternal;
	public FGuid TargetEntityId;
}
