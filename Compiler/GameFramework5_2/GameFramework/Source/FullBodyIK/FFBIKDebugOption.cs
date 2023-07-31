#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FBIKDebugOption.h")]
public partial struct FFBIKDebugOption {
	public bool bDrawDebugHierarchy;
	public bool bColorAngularMotionStrength;
	public bool bColorLinearMotionStrength;
	public bool bDrawDebugAxes;
	public bool bDrawDebugEffector;
	public bool bDrawDebugConstraints;
	public FTransform DrawWorldOffset;
	public float DrawSize;
}
