#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BrushComponent.h")]
///<summary>A brush component defines a shape that can be modified within the editor. They are used both as part of BSP building, and for volumes.</summary>
public partial class UBrushComponent : UPrimitiveComponent {
// BrushComponent
	public UModel Brush;
	public UBodySetup BrushBodySetup;
	public FVector PrePivot_DEPRECATED;
}
