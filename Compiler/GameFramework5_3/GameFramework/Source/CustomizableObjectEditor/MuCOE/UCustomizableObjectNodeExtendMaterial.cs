namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeExtendMaterial.h")]
public partial class UCustomizableObjectNodeExtendMaterial : UCustomizableObjectNodeMaterialBase {
	public static UClass StaticClass() {return default;}
	///<summary>Tags</summary>
	public TArray<string> Tags;
	///<summary>ParentMaterialObject</summary>
	public UCustomizableObject ParentMaterialObject;
	///<summary>ParentMaterialNodeId</summary>
	public FGuid ParentMaterialNodeId;
	///<summary>Relates a Parameter id to a Pin. Only used to improve performance.</summary>
	public TMap<FGuid,FEdGraphPinReference> PinsParameter;
	///<summary>Deprecated properties</summary>
	public TArray<FCustomizableObjectNodeExtendMaterialImage> Images_DEPRECATED;
}
