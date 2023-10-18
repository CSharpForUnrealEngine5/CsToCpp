namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RevolveSplineTool.h")]
public partial class URevolveSplineToolProperties : URevolveProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Determines how points to revolve are actually picked from the spline.</summary>
	public ERevolveSplineSampleMode SampleMode;
	///<summary>How far to allow the triangulation boundary can deviate from the spline curve before we add more vertices.</summary>
	public double ErrorTolerance;
	///<summary>The maximal distance that the spacing should be allowed to be.</summary>
	public double MaxSampleDistance;
	///<summary>Determines how end caps are created. This is not relevant if the end caps are not visible or if the path is not closed.</summary>
	public ERevolvePropertiesCapFillMode CapFillMode;
	///<summary>Connect the ends of an open path to the axis to add caps to the top and bottom of the revolved result.</summary>
	public bool bClosePathToAxis;
	///<summary>Sets the revolution axis origin.</summary>
	public FVector AxisOrigin;
	///<summary>Sets the revolution axis pitch and yaw.</summary>
	public FVector2D AxisOrientation;
	///<summary>If true, the revolution axis is re-fit to the input spline on each tool start. If false, the previous</summary>
	public bool bResetAxisOnStart;
}
