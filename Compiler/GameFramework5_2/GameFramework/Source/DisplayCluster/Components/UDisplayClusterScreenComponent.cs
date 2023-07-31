#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple projection policy screen component</summary>
[CppInclude("Components/DisplayClusterScreenComponent.h")]
public partial class UDisplayClusterScreenComponent : UStaticMeshComponent {
	///<summary>Return the screen size adjusted by its transform scale.</summary>
	public  FVector2D GetScreenSize() { return default; }
	///<summary>Set screen size (update transform scale).</summary>
	public  void SetScreenSize(FVector2D Size) {}
	///<summary>Adjust the size of the screen.</summary>
	public FVector2D Size;
}
