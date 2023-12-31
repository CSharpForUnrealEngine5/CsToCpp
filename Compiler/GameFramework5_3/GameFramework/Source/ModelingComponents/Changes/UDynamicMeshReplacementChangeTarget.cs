namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bare bones wrapper of FDynamicMesh3 that supports MeshReplacementChange-based updates.  Shares the mesh ptr with the MeshReplacementChange objects, so it must not be changed directly</summary>
[CppInclude("Changes/DynamicMeshChangeTarget.h")]
public partial class UDynamicMeshReplacementChangeTarget : UObject {
	public static UClass StaticClass() {return default;}
}
