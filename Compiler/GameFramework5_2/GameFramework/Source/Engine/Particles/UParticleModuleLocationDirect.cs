#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationDirect.h")]
public partial class UParticleModuleLocationDirect : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The location of the particle at a give time. Retrieved using the particle RelativeTime.</summary>
	public FRawDistributionVector Location;
	///<summary>An offset to apply to the position retrieved from the Location calculation.</summary>
	public FRawDistributionVector LocationOffset;
	///<summary>Scales the velocity of the object at a given point in the time-line.</summary>
	public FRawDistributionVector ScaleFactor;
	///<summary>Currently unused.</summary>
	public FRawDistributionVector Direction;
}
