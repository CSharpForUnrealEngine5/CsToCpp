#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic.h")]
public partial class UParticleModuleParameterDynamic : UParticleModuleParameterBase {
	///<summary>The dynamic parameters this module uses.</summary>
	public TArray<FEmitterDynamicParameter> DynamicParams;
	///<summary>Flags for optimizing update</summary>
	public int UpdateFlags;
	///<summary>bUsesVelocity</summary>
	public bool bUsesVelocity;
}
