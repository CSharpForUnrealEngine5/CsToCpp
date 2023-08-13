namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ReflectionCapture.h")]
public partial class AReflectionCapture : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Reflection capture component.</summary>
	public UReflectionCaptureComponent CaptureComponent;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>CaptureOffsetComponent</summary>
	public UBillboardComponent CaptureOffsetComponent;
}
