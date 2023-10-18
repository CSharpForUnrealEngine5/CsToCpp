namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlComponent.h")]
///<summary>Specifies how any reset to cached target should work.</summary>
public enum EResetToCachedTargetBehavior {
	ResetImmediately=0,
	ResetDuringUpdateControls=1,
}
