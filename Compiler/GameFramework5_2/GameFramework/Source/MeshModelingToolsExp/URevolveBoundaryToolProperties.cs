namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RevolveBoundaryTool.h")]
public partial class URevolveBoundaryToolProperties : URevolveProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Determines how end caps are created. This is not relevant if the end caps are not visible or if the path is not closed.</summary>
	public ERevolvePropertiesCapFillMode CapFillMode;
	///<summary>If true, displays the original mesh in addition to the revolved boundary.</summary>
	public bool bDisplayInputMesh;
	///<summary>Sets the revolution axis origin.</summary>
	public FVector AxisOrigin;
	///<summary>Sets the revolution axis pitch and yaw.</summary>
	public FVector2D AxisOrientation;
}
