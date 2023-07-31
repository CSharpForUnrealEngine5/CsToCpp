#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineSplineComponent.h")]
public partial class UCineSplineComponent : USplineComponent {
	///<summary>Defaults which are used to propagate values to spline points on instances of this in the world</summary>
	public FCineSplineCurveDefaults CameraSplineDefaults;
	///<summary>Pointer to metadata</summary>
	public UCineSplineMetadata CineSplineMetadata;
	///<summary>Set focal lenght metadata at a given splint point</summary>
	public  void SetFocalLengthAtSplinePoint(int PointIndex,float Value) {}
	///<summary>Set aperture metadata at a given spline point</summary>
	public  void SetApertureAtSplinePoint(int PointIndex,float value) {}
	///<summary>Set focus distance metadata at a given spline point</summary>
	public  void SetFocusDistanceAtSplinePoint(int PointIndex,float value) {}
	///<summary>Set custom position metadata at a given spline point</summary>
	public  void SetAbsolutePositionAtSplinePoint(int PointIndex,float value) {}
	///<summary>Set camera rotation metadata at a given spline point</summary>
	public  void SetPointRotationAtSplinePoint(int PointIndex,FQuat value) {}
	///<summary>Returns true if there is a spline point at given custom position</summary>
	public  bool FindSplineDataAtPosition(float InPosition,int OutIndex,float Tolerance/*=0.001f*/) { return default; }
	///<summary>Update spline point data at the given spline point</summary>
	public  void UpdateSplineDataAtIndex(int InIndex,FCineSplinePointData InPointData) {}
	///<summary>Add a new spline point data at the given custom position</summary>
	public  void AddSplineDataAtPosition(float InPosition,FCineSplinePointData InPointData) {}
	///<summary>Get a spline point data at the given custom position</summary>
	public  FCineSplinePointData GetSplineDataAtPosition(float InPosition) { return default; }
	///<summary>Get input key value from custom position</summary>
	public  float GetInputKeyAtPosition(float InPosition) { return default; }
	///<summary>Get custom position value at spline input key</summary>
	public  float GetPositionAtInputKey(float InKey) { return default; }
	///<summary>Get camera rotation metadata property value along the spline at spline point</summary>
	public  FQuat GetPointRotationAtSplinePoint(int Index) { return default; }
	///<summary>Get camera rotation metadata value along the spline at spline input key</summary>
	public  FQuat GetPointRotationAtSplineInputKey(float InKey) { return default; }
	///<summary>FOnSplineEdited_BP</summary>
	public  void FOnSplineEdited_BP() {}
	///<summary>Event trigerred when spline is edited</summary>
	public FOnSplineEdited_BP OnSplineEdited_BP;
}
