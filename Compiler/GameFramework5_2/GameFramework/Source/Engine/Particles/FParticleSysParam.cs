#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
///<summary>Struct used for a particular named instance parameter for this ParticleSystemComponent.</summary>
public partial struct FParticleSysParam {
// ParticleSysParam
	public string Name;
	public EParticleSysParamType ParamType;
	public float Scalar;
	public float Scalar_Low;
	public FVector Vector;
	public FVector Vector_Low;
	public FColor Color;
	public AActor Actor;
	public UMaterialInterface Material;
}
