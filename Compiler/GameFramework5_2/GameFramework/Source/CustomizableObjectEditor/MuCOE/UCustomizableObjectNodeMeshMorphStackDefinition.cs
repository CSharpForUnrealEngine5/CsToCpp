namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMeshMorphStackDefinition.h")]
public partial class UCustomizableObjectNodeMeshMorphStackDefinition : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>List with all the morphs of the linked skeletal mesh</summary>
	public TArray<string> MorphNames;
}
