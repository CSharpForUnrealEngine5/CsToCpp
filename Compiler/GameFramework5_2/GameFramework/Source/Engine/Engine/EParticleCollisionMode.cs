#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies how particle collision is computed for GPU particles</summary>
[CppEnumInNamespace]
public enum EParticleCollisionMode {
	SceneDepth=0,
	DistanceField=1,
}
