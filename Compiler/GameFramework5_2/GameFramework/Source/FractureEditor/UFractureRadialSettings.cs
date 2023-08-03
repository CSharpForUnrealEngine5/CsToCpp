#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolRadial.h")]
public partial class UFractureRadialSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Center of generated pattern. Only used when &quot;Use Gizmo&quot; is disabled</summary>
	public FVector Center;
	///<summary>Normal to plane in which sites are generated. Only used when &quot;Use Gizmo&quot; is disabled</summary>
	public FVector Normal;
	///<summary>bPositionedByGizmo</summary>
	public bool bPositionedByGizmo;
	///<summary>Number of angular steps</summary>
	public int AngularSteps;
	///<summary>Angle offset at each radial step (in degrees)</summary>
	public float AngleOffset;
	///<summary>Amount of global variation to apply to each angular step (in degrees)</summary>
	public float AngularNoise;
	///<summary>Pattern radius (in cm)</summary>
	public float Radius;
	///<summary>Number of radial steps</summary>
	public int RadialSteps;
	///<summary>Radial steps will follow a distribution based on this exponent, i.e., Pow(distance from center, RadialStepExponent)</summary>
	public float RadialStepExponent;
	///<summary>Minimum radial separation between any two voronoi points (in cm)</summary>
	public float RadialMinStep;
	///<summary>Amount of global variation to apply to each radial step (in cm)</summary>
	public float RadialNoise;
	///<summary>Amount to randomly displace each Voronoi site radially (in cm)</summary>
	public float RadialVariability;
	///<summary>Amount to randomly displace each Voronoi site in angle (in degrees)</summary>
	public float AngularVariability;
	///<summary>Amount to randomly displace each Voronoi site in the direction of the rotation axis (in cm)</summary>
	public float AxialVariability;
}
