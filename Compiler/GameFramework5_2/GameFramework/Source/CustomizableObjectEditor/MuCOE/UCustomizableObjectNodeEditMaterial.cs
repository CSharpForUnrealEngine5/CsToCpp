namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeEditMaterial.h")]
public partial class UCustomizableObjectNodeEditMaterial : UCustomizableObjectNodeEditLayoutBlocks {
	public static UClass StaticClass() {return default;}
	///<summary>Relates a Parameter id to a Pin. Only used to improve performance.</summary>
	public TMap<FGuid,FEdGraphPinReference> PinsParameter;
	///<summary>Deprecated properties</summary>
	public TArray<FCustomizableObjectNodeEditMaterialImage> Images_DEPRECATED;
	///<summary>Old layout blocks to patch. Now in parent class.</summary>
	public TArray<int> Blocks_DEPRECATED;
}
