#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a directional light actor.</summary>
[CppInclude("Engine/DirectionalLight.h")]
public partial class ADirectionalLight : ALight {
	public static UClass StaticClass() {return default;}
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
	///<summary>EditorOnly reference to the light component to allow it to be displayed in the details panel correctly</summary>
	public UDirectionalLightComponent DirectionalLightComponent;
}
