namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterialVariation.h")]
public partial class UCustomizableObjectNodeMaterialVariation : UCustomizableObjectNodeMaterialBase {
	public static UClass StaticClass() {return default;}
	///<summary>Type</summary>
	public ECustomizableObjectNodeMaterialVariationType Type;
	///<summary>Variations</summary>
	public TArray<FCustomizableObjectMaterialVariation> Variations;
}
