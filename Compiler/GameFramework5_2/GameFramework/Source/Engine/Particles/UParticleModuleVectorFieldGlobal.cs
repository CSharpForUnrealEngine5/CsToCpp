namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/VectorField/ParticleModuleVectorFieldGlobal.h")]
public partial class UParticleModuleVectorFieldGlobal : UParticleModuleVectorFieldBase {
	public static UClass StaticClass() {return default;}
	///<summary>Property override value for global vector field tightness.</summary>
	public bool bOverrideGlobalVectorFieldTightness;
	///<summary>Global vector field scale.</summary>
	public float GlobalVectorFieldScale;
	///<summary>Global vector field tightness override.</summary>
	public float GlobalVectorFieldTightness;
}
