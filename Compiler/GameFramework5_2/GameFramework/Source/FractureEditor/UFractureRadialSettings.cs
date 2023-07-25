#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolRadial.h")]
public partial class UFractureRadialSettings : UFractureToolSettings {
// FractureRadialSettings
	public FVector Center;
	public FVector Normal;
	public bool bPositionedByGizmo;
	public int AngularSteps;
	public float AngleOffset;
	public float AngularNoise;
	public float Radius;
	public int RadialSteps;
	public float RadialStepExponent;
	public float RadialMinStep;
	public float RadialNoise;
	public float RadialVariability;
	public float AngularVariability;
	public float AxialVariability;
}
