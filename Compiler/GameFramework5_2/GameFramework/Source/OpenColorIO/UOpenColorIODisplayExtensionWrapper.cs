#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIODisplayExtensionWrapper.h")]
///<summary>This Blueprintable object can hold an OCIO Scene View Extension.</summary>
public partial class UOpenColorIODisplayExtensionWrapper : UObject {
// OpenColorIODisplayExtensionWrapper
	public  FOpenColorIODisplayConfiguration GetOpenColorIOConfiguration() { return default; }
	public  void SetOpenColorIOConfiguration(FOpenColorIODisplayConfiguration InDisplayConfiguration) {}
	public  void SetSceneExtensionIsActiveFunction(FSceneViewExtensionIsActiveFunctor IsActiveFunction) {}
	public  void SetSceneExtensionIsActiveFunctions(TArray<FSceneViewExtensionIsActiveFunctor> IsActiveFunctions) {}
	public  void RemoveSceneExtension() {}
	public static UOpenColorIODisplayExtensionWrapper CreateOpenColorIODisplayExtension(FOpenColorIODisplayConfiguration InDisplayConfiguration,FSceneViewExtensionIsActiveFunctor IsActiveFunction) { return default; }
	public static UOpenColorIODisplayExtensionWrapper CreateInGameOpenColorIODisplayExtension(FOpenColorIODisplayConfiguration InDisplayConfiguration) { return default; }
}
