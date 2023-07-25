#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/PreviewAssetAttachComponent.h")]
///<summary>Preview items that are attached to the skeleton *</summary>
public partial struct FPreviewAttachedObjectPair {
// PreviewAttachedObjectPair
	public TSoftObjectPtr<UObject> AttachedObject;
	public UObject Object_DEPRECATED;
	public string AttachedTo;
}
