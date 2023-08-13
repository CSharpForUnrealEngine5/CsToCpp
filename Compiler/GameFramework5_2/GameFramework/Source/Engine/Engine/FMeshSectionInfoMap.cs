namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Map containing per-section settings for each section of each LOD.</summary>
[CppInclude("Engine/StaticMesh.h")]
public partial struct FMeshSectionInfoMap {
	public TMap<uint,FMeshSectionInfo> Map;
}
