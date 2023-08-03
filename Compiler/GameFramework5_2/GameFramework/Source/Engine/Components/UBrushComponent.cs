#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A brush component defines a shape that can be modified within the editor. They are used both as part of BSP building, and for volumes.</summary>
[CppInclude("Components/BrushComponent.h")]
public partial class UBrushComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Brush</summary>
	public UModel Brush;
	///<summary>Description of collision</summary>
	public UBodySetup BrushBodySetup;
	///<summary>Local space translation</summary>
	public FVector PrePivot_DEPRECATED;
}
