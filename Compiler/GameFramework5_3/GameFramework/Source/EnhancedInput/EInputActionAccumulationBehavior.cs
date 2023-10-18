namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputAction.h")]
///<summary>This is an advanced setting that allows you to change how the value of an Input Action is calculated when there are</summary>
public enum EInputActionAccumulationBehavior {
	TakeHighestAbsoluteValue=0,
	Cumulative=1,
}
