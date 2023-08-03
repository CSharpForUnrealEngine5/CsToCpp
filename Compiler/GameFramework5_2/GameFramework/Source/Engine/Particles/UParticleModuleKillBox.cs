#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Kill/ParticleModuleKillBox.h")]
public partial class UParticleModuleKillBox : UParticleModuleKillBase {
	public static UClass StaticClass() {return default;}
	///<summary>The lower left corner of the box.</summary>
	public FRawDistributionVector LowerLeftCorner;
	///<summary>The upper right corner of the box.</summary>
	public FRawDistributionVector UpperRightCorner;
	///<summary>If true, the box coordinates are in world space./</summary>
	public bool bAbsolute;
	///<summary>If true, particles INSIDE the box will be killed.</summary>
	public bool bKillInside;
	///<summary>If true, the box will always be axis aligned and non-scalable.</summary>
	public bool bAxisAlignedAndFixedSize;
}
