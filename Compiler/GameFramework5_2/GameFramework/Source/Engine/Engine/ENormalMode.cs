#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>Optimization settings used to simplify mesh LODs.</summary>
public enum ENormalMode {
	NM_PreserveSmoothingGroups=0,
	NM_RecalculateNormals=1,
	NM_RecalculateNormalsSmooth=2,
	NM_RecalculateNormalsHard=3,
	TEMP_BROKEN=4,
	ENormalMode_MAX=5,
}
