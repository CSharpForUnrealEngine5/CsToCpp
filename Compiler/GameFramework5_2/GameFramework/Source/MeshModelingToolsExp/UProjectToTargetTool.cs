namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Project one mesh surface onto another, while undergoing remeshing. Subclass of URemeshMeshTool to avoid duplication.</summary>
[CppInclude("ProjectToTargetTool.h")]
public partial class UProjectToTargetTool : URemeshMeshTool {
	public static UClass StaticClass() {return default;}
}
