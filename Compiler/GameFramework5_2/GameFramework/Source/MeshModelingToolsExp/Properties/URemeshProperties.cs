#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RemeshProperties.h")]
public partial class URemeshProperties : UMeshConstraintProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Amount of Vertex Smoothing applied within Remeshing</summary>
	public float SmoothingStrength;
	///<summary>Enable edge flips in Remeshing (tends to lose edges/detail)</summary>
	public bool bFlips;
	///<summary>Enable edge splits in Remeshing</summary>
	public bool bSplits;
	///<summary>Enable edge collapses in Remeshing</summary>
	public bool bCollapses;
}
