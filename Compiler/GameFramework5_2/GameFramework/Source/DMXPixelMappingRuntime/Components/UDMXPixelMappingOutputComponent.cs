#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DMXPixelMappingOutputComponent.h")]
///<summary>Base class for all Designer and configurable components</summary>
public partial class UDMXPixelMappingOutputComponent : UDMXPixelMappingBaseComponent {
// DMXPixelMappingOutputComponent
	public int ZOrder;
	public FLinearColor EditorColor;
	public EDMXPixelBlendingQuality CellBlendingQuality;
	public float PositionX;
	public float PositionY;
	public float SizeX;
	public float SizeY;
	public bool bLockInDesigner;
	public bool bVisibleInDesigner;
}
