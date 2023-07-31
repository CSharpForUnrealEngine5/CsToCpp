#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class controls/sets up a node that modifies the min/max bounds of the input points.</summary>
[CppInclude("Elements/PCGBoundsModifier.h")]
public partial class UPCGBoundsModifierSettings : UPCGSettings {
	///<summary>Mode</summary>
	public EPCGBoundsModifierMode Mode;
	///<summary>BoundsMin</summary>
	public FVector BoundsMin;
	///<summary>BoundsMax</summary>
	public FVector BoundsMax;
	///<summary>bAffectSteepness</summary>
	public bool bAffectSteepness;
	///<summary>Steepness</summary>
	public float Steepness;
}
