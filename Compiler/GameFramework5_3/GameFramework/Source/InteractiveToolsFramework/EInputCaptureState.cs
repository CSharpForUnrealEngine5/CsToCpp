namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputBehavior.h")]
///<summary>FInputCaptureUpdate uses this type to indicate what state the capturing Behavior</summary>
public enum EInputCaptureState {
	Begin=1,
	Continue=2,
	End=3,
	Ignore=4,
}
