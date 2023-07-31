#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used for a particular named instance parameter for this ParticleSystemComponent.</summary>
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial struct FParticleSysParam {
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
