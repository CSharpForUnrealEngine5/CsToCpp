#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Blueprintable object can hold an OCIO Scene View Extension.</summary>
[CppInclude("OpenColorIODisplayExtensionWrapper.h")]
public partial class UOpenColorIODisplayExtensionWrapper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the display extension OCIO configuration.</summary>
	public  FOpenColorIODisplayConfiguration GetOpenColorIOConfiguration() { return default; }
	///<summary>Sets the display extension OCIO configuration.</summary>
	public  void SetOpenColorIOConfiguration(FOpenColorIODisplayConfiguration InDisplayConfiguration) {}
	///<summary>Sets a single activation function. Will remove any others.</summary>
	public  void SetSceneExtensionIsActiveFunction(FSceneViewExtensionIsActiveFunctor IsActiveFunction) {}
	///<summary>Sets an array of activation functions. Will remove any others.</summary>
	public  void SetSceneExtensionIsActiveFunctions(TArray<FSceneViewExtensionIsActiveFunctor> IsActiveFunctions) {}
	///<summary>Removes the extension.</summary>
	public  void RemoveSceneExtension() {}
	///<summary>Creates an instance of this object, configured with the given arguments (OCIO and activation function).</summary>
	public static UOpenColorIODisplayExtensionWrapper CreateOpenColorIODisplayExtension(FOpenColorIODisplayConfiguration InDisplayConfiguration,FSceneViewExtensionIsActiveFunctor IsActiveFunction) { return default; }
	///<summary>Creates an instance of this object, configured for use in game with the given OCIO configuration.</summary>
	public static UOpenColorIODisplayExtensionWrapper CreateInGameOpenColorIODisplayExtension(FOpenColorIODisplayConfiguration InDisplayConfiguration) { return default; }
}
