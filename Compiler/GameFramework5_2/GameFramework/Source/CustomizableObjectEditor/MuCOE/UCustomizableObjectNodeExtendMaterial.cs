#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeExtendMaterial.h")]
public partial class UCustomizableObjectNodeExtendMaterial : UCustomizableObjectNodeMaterialBase {
// CustomizableObjectNodeExtendMaterial
	public TArray<string> Tags;
	public UCustomizableObject ParentMaterialObject;
	public FGuid ParentMaterialNodeId;
	public TMap<FGuid,FEdGraphPinReference> PinsParameter;
	public TArray<FCustomizableObjectNodeExtendMaterialImage> Images_DEPRECATED;
}
