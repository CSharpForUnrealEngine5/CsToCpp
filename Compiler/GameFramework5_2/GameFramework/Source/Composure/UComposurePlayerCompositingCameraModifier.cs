namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Private camera manager for  UComposurePlayerCompositingTarget.</summary>
[CppInclude("ComposurePlayerCompositingCameraModifier.h")]
public partial class UComposurePlayerCompositingCameraModifier : UCameraModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Current player camera manager the target is bind on.</summary>
	public object /*Target*/ Target;
}
