namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/MovementComponent.h")]
///<summary>Setting that controls behavior when movement is restricted to a 2D plane defined by a specific axis/normal,</summary>
public enum EPlaneConstraintAxisSetting {
	Custom=0,
	X=1,
	Y=2,
	Z=3,
	UseGlobalPhysicsSetting=4,
}
