#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Calculates the distance between two points (inherently a n*n operation)</summary>
[CppInclude("Elements/PCGDistance.h")]
public partial class UPCGDistanceSettings : UPCGSettings {
	///<summary>The name of the attribute to store on the point.Use &#39;None&#39; to disable</summary>
	public string AttributeName;
	///<summary>Controls whether the attribute will be a scalar or a vector</summary>
	public bool bOutputDistanceVector;
	///<summary>If true, will also set the density to be 0 - 1 based on MaximumDistance</summary>
	public bool bSetDensity;
	///<summary>A maximum distance to search, which is used as an optimization</summary>
	public double MaximumDistance;
	///<summary>What shape is used on the &#39;source&#39; points</summary>
	public PCGDistanceShape SourceShape;
	///<summary>What shape is used on the &#39;target&#39; points</summary>
	public PCGDistanceShape TargetShape;
}
