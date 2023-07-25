#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ReflectionCaptureComponent.h")]
///<summary>-> will be exported to EngineDecalClasses.h</summary>
public partial class UReflectionCaptureComponent : USceneComponent {
// ReflectionCaptureComponent
	public UBillboardComponent CaptureOffsetComponent;
	public EReflectionSourceType ReflectionSourceType;
	public UTextureCube Cubemap;
	public float SourceCubemapAngle;
	public float Brightness;
	public FVector CaptureOffset;
	public FGuid MapBuildDataId;
}
