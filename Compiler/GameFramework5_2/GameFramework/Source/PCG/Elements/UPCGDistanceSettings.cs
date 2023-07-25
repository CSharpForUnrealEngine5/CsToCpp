#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDistance.h")]
///<summary>Calculates the distance between two points (inherently a n*n operation)</summary>
public partial class UPCGDistanceSettings : UPCGSettings {
// PCGDistanceSettings
	public string AttributeName;
	public bool bOutputDistanceVector;
	public bool bSetDensity;
	public double MaximumDistance;
	public PCGDistanceShape SourceShape;
	public PCGDistanceShape TargetShape;
}
