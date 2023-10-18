namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/CameraShakeTestObjects.h")]
public partial class UConstantCameraShakePattern : USimpleCameraShakePattern {
	public static UClass StaticClass() {return default;}
	///<summary>LocationOffset</summary>
	public FVector LocationOffset;
	///<summary>RotationOffset</summary>
	public FRotator RotationOffset;
}
