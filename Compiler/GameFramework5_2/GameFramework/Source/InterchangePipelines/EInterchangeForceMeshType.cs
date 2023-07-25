#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAssetsPipelineSharedSettings.h")]
///<summary>Force mesh type, if user want to import all meshes as one type</summary>
public enum EInterchangeForceMeshType {
	IFMT_None=0,
	IFMT_StaticMesh=1,
	IFMT_SkeletalMesh=2,
	IFMT_MAX=3,
}
