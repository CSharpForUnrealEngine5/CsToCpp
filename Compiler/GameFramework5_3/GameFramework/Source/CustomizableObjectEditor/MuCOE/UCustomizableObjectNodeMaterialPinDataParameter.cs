namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Material Parameters.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterial.h")]
public partial class UCustomizableObjectNodeMaterialPinDataParameter : UCustomizableObjectNodePinData {
	public static UClass StaticClass() {return default;}
	///<summary>Texture Parameter Id.</summary>
	public FGuid ParameterId;
}
