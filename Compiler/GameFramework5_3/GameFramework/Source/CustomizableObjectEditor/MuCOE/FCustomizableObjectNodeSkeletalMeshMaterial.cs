namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCustomizableObjectNodeSkeletalMesh</summary>
[CppInclude("MuCOE/CustomizableObjectEditor_Deprecated.h")]
public partial struct FCustomizableObjectNodeSkeletalMeshMaterial {
	public string Name;
	public UEdGraphPin_Deprecated MeshPin_DEPRECATED;
	public TArray<UEdGraphPin_Deprecated> LayoutPins_DEPRECATED;
	public TArray<UEdGraphPin_Deprecated> ImagePins_DEPRECATED;
	public FEdGraphPinReference MeshPinRef;
	public TArray<FEdGraphPinReference> LayoutPinsRef;
	public TArray<FEdGraphPinReference> ImagePinsRef;
}
