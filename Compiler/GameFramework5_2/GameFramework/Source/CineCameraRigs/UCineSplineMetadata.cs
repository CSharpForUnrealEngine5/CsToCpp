#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineSplineMetadata.h")]
public partial class UCineSplineMetadata : USplineMetadata {
	///<summary>AbsolutePosition</summary>
	public FInterpCurveFloat AbsolutePosition;
	///<summary>FocalLength</summary>
	public FInterpCurveFloat FocalLength;
	///<summary>Aperture</summary>
	public FInterpCurveFloat Aperture;
	///<summary>FocusDistance</summary>
	public FInterpCurveFloat FocusDistance;
	///<summary>PointRotation</summary>
	public FInterpCurveQuat PointRotation;
}
