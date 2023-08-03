#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for Diffusion Smoothing</summary>
[CppInclude("SmoothMeshTool.h")]
public partial class UDiffusionSmoothProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Amount of smoothing allowed per step. Smaller steps will avoid things like collapse of small/thin features.</summary>
	public float SmoothingPerStep;
	///<summary>Number of Smoothing iterations</summary>
	public int Steps;
	///<summary>If this is false, the smoother will try to reshape the triangles to be more regular, which will distort UVs</summary>
	public bool bPreserveUVs;
}
