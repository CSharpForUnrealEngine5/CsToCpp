#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMesh.h")]
///<summary>Strategy used for storing additional cloth deformer mappings depending on the</summary>
public enum EClothLODBiasMode {
	MappingsToSameLOD=0,
	MappingsToMinLOD=1,
	MappingsToAnyLOD=2,
}
