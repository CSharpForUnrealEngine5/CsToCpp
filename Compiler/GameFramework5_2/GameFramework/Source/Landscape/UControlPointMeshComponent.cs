#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlPointMeshComponent.h")]
public partial class UControlPointMeshComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bSelected</summary>
	public bool bSelected;
	///<summary>The max draw distance to use in the main pass when also rendering to a runtime virtual texture.</summary>
	public float VirtualTextureMainPassMaxDrawDistance;
}
