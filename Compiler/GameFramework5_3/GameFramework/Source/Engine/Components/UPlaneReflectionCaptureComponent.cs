namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/PlaneReflectionCaptureComponent.h")]
public partial class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of the area that can receive reflections from this capture.</summary>
	public float InfluenceRadiusScale;
	///<summary>PreviewInfluenceRadius</summary>
	public UDrawSphereComponent PreviewInfluenceRadius;
	///<summary>PreviewCaptureBox</summary>
	public UBoxComponent PreviewCaptureBox;
}
