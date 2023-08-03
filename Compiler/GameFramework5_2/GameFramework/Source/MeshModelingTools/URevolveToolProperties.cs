#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawAndRevolveTool.h")]
public partial class URevolveToolProperties : URevolveProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Determines how end caps are created. This is not relevant if the end caps are not visible or if the path is not closed.</summary>
	public ERevolvePropertiesCapFillMode CapFillMode;
	///<summary>Connect the ends of an open path to the axis to add caps to the top and bottom of the revolved result.</summary>
	public bool bClosePathToAxis;
	///<summary>Sets the draw plane origin. The revolution axis is the X axis in the plane.</summary>
	public FVector DrawPlaneOrigin;
	///<summary>Sets the draw plane orientation. The revolution axis is the X axis in the plane.</summary>
	public FRotator DrawPlaneOrientation;
	///<summary>Enables snapping while editing the path.</summary>
	public bool bEnableSnapping;
	///<summary>Not user visible- used to disallow draw plane modification.</summary>
	public bool bAllowedToEditDrawPlane;
}
