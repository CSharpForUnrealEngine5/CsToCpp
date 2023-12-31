namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic.h")]
public partial class UParticleModuleParameterDynamic : UParticleModuleParameterBase {
	public static UClass StaticClass() {return default;}
	///<summary>The dynamic parameters this module uses.</summary>
	public TArray<FEmitterDynamicParameter> DynamicParams;
	///<summary>Flags for optimizing update</summary>
	public int UpdateFlags;
	///<summary>bUsesVelocity</summary>
	public bool bUsesVelocity;
}
