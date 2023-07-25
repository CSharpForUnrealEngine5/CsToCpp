#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawAndRevolveTool.h")]
public partial class URevolveToolProperties : URevolveProperties {
// RevolveToolProperties
	public ERevolvePropertiesCapFillMode CapFillMode;
	public bool bClosePathToAxis;
	public FVector DrawPlaneOrigin;
	public FRotator DrawPlaneOrientation;
	public bool bEnableSnapping;
	public bool bAllowedToEditDrawPlane;
}
