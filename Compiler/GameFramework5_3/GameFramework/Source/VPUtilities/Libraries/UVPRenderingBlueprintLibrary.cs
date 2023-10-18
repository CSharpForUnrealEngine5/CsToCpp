namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint function library supporting Virtual Production rendering use cases.</summary>
[CppInclude("Libraries/VPRenderingBlueprintLibrary.h")]
public partial class UVPRenderingBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a functor to activate a scene view extension when the FViewport in the SceneViewExtensionContext is selectively:</summary>
	public static void GenerateSceneViewExtensionIsActiveFunctorForViewportType(FSceneViewExtensionIsActiveFunctor OutIsActiveFunction,bool bPIE/*=false*/,bool bSIE/*=false*/,bool bEditorActive/*=false*/,bool bGamePrimary/*=false*/) {}
}
