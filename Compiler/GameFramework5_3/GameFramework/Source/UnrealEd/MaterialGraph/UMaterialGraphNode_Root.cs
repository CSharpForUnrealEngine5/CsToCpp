namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraphNode_Root.h")]
public partial class UMaterialGraphNode_Root : UMaterialGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Material whose inputs this root node represents</summary>
	public UMaterial Material;
}
