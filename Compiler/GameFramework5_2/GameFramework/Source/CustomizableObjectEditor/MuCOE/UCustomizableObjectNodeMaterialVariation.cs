#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
