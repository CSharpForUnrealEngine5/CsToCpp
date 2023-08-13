namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshMorphStackApplication.h")]
public partial class UCustomizableObjectNodeMeshMorphStackApplication : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>List with all the morphs of the linked skeletal mesh</summary>
	public TArray<string> MorphNames;
}
