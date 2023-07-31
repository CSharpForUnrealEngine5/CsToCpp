#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for how the scene’s coordinate system is constructed. This feature is used by ARKit.</summary>
public enum EARWorldAlignment {
	Gravity=0,
	GravityAndHeading=1,
	Camera=2,
}
