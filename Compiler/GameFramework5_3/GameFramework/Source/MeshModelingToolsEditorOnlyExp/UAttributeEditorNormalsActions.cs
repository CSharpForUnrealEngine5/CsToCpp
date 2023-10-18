namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorNormalsActions : UAttributeEditorActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Remove any hard edges / split normals, setting all normals to a single averaged vertex normal</summary>
	public void ResetHardNormals() {}
	///<summary>Clear Tangents from the mesh</summary>
	public void DiscardTangents() {}
}
