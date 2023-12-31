namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Private blendable interface for  UComposurePostProcessPass.</summary>
[CppInclude("ComposurePostProcessBlendable.h")]
public partial class UComposurePostProcessBlendable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current player camera manager the target is bind on.</summary>
	public UComposurePostProcessPass Target;
}
