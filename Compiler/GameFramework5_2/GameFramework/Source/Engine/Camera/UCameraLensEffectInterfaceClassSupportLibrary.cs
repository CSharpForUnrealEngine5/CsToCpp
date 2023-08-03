#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraLensEffectInterface.h")]
public partial class UCameraLensEffectInterfaceClassSupportLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the class represented by this lens effect wrapper...</summary>
	public static UClass GetInterfaceClass(FCameraLensInterfaceClassSupport CameraLens) { return default; }
	///<summary>Check whether or not the interface class is valid</summary>
	public static void IsInterfaceClassValid(FCameraLensInterfaceClassSupport CameraLens,EInterfaceValidResult Result) {}
	///<summary>Evaluate the live interface to see if it is a valid reference.</summary>
	public static void IsInterfaceValid(object /*CameraLens*/ CameraLens,EInterfaceValidResult Result) {}
	///<summary>Set the represented class of the passed in variable. Note: Check the tooltips on the individual pins.</summary>
	public static void SetInterfaceClass(UClass Class,FCameraLensInterfaceClassSupport Var,EInterfaceValidResult Result) {}
}
