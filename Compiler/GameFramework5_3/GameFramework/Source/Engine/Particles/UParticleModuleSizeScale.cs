namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Size/ParticleModuleSizeScale.h")]
public partial class UParticleModuleSizeScale : UParticleModuleSizeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The amount the BaseSize should be scaled before being used as the size of the particle.</summary>
	public FRawDistributionVector SizeScale;
	///<summary>Ignored</summary>
	public bool EnableX;
	///<summary>Ignored</summary>
	public bool EnableY;
	///<summary>Ignored</summary>
	public bool EnableZ;
}
