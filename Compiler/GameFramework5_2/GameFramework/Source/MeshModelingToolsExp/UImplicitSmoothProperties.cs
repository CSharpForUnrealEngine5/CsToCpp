#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for Implicit smoothing</summary>
[CppInclude("SmoothMeshTool.h")]
public partial class UImplicitSmoothProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Smoothing speed //UPROPERTY(EditAnywhere, Category = ImplicitSmoothing, meta = (UIMin = &quot;0.0&quot;, UIMax = &quot;1.0&quot;, ClampMin = &quot;0.0&quot;, ClampMax = &quot;1.0&quot;))</summary>
	public float SmoothSpeed;
	///<summary>Desired Smoothness. This is not a linear quantity, but larger numbers produce smoother results</summary>
	public float Smoothness;
	///<summary>If this is false, the smoother will try to reshape the triangles to be more regular, which will distort UVs</summary>
	public bool bPreserveUVs;
	///<summary>Magic number that allows you to try to correct for shrinking caused by smoothing</summary>
	public float VolumeCorrection;
}
