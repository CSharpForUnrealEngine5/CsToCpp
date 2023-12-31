namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineSplineMetadata.h")]
public partial class UCineSplineMetadata : USplineMetadata {
	public static UClass StaticClass() {return default;}
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
