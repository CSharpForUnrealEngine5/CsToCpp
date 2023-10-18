namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeEditMaterialBase.h")]
public partial class UCustomizableObjectNodeEditMaterialBase : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Index of the layout to use to patch blocks.</summary>
	public int ParentLayoutIndex;
	///<summary>ParentMaterialObject</summary>
	public UCustomizableObject ParentMaterialObject;
	///<summary>ParentMaterialNodeId</summary>
	public FGuid ParentMaterialNodeId;
}
