#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SceneCapturer.h")]
public partial class USceneCapturer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>store post process volumes data</summary>
	public TArray<FPostProcessVolumeData> PPVolumeArray;
	///<summary>CaptureSceneComponent will be used as parent of capturecomponents to provide world location and rotation.</summary>
	public USceneComponent CaptureSceneComponent;
}
