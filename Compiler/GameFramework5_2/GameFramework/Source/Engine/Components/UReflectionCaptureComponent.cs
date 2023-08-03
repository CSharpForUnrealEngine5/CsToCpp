#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/ReflectionCaptureComponent.h")]
public partial class UReflectionCaptureComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CaptureOffsetComponent</summary>
	public UBillboardComponent CaptureOffsetComponent;
	///<summary>Indicates where to get the reflection source from.</summary>
	public EReflectionSourceType ReflectionSourceType;
	///<summary>Cubemap to use for reflection if ReflectionSourceType is set to RS_SpecifiedCubemap.</summary>
	public UTextureCube Cubemap;
	///<summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
	public float SourceCubemapAngle;
	///<summary>A brightness control to scale the captured scene&#39;s reflection intensity.</summary>
	public float Brightness;
	///<summary>World space offset to apply before capturing.</summary>
	public FVector CaptureOffset;
	///<summary>Guid for map build data</summary>
	public FGuid MapBuildDataId;
}
