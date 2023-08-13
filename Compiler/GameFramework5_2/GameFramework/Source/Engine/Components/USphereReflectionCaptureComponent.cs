namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/SphereReflectionCaptureComponent.h")]
public partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of the area that can receive reflections from this capture.</summary>
	public float InfluenceRadius;
	///<summary>Not needed anymore, not yet removed in case the artist setup values are needed in the future</summary>
	public float CaptureDistanceScale;
	///<summary>PreviewInfluenceRadius</summary>
	public UDrawSphereComponent PreviewInfluenceRadius;
}
