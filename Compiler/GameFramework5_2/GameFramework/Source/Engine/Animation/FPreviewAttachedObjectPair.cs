namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Preview items that are attached to the skeleton *</summary>
[CppInclude("Animation/PreviewAssetAttachComponent.h")]
public partial struct FPreviewAttachedObjectPair {
	public TSoftObjectPtr<UObject> AttachedObject;
	public UObject Object_DEPRECATED;
	public string AttachedTo;
}
