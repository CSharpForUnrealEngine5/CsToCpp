#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGBoundsModifier.h")]
///<summary>This class controls/sets up a node that modifies the min/max bounds of the input points.</summary>
public partial class UPCGBoundsModifierSettings : UPCGSettings {
// PCGBoundsModifierSettings
	public EPCGBoundsModifierMode Mode;
	public FVector BoundsMin;
	public FVector BoundsMax;
	public bool bAffectSteepness;
	public float Steepness;
}
