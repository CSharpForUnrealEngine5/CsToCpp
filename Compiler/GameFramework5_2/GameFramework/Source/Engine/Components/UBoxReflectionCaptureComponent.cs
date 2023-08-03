#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/BoxReflectionCaptureComponent.h")]
public partial class UBoxReflectionCaptureComponent : UReflectionCaptureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Adjust capture transition distance</summary>
	public float BoxTransitionDistance;
	///<summary>PreviewInfluenceBox</summary>
	public UBoxComponent PreviewInfluenceBox;
	///<summary>PreviewCaptureBox</summary>
	public UBoxComponent PreviewCaptureBox;
}
