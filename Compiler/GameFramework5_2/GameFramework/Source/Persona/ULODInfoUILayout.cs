namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LODInfoUILayout.h")]
public partial class ULODInfoUILayout : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Struct containing information for a LOD level, such as materials to use, and when use the LOD.</summary>
	public FSkeletalMeshLODInfo LODInfo;
}
