namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Designer and configurable components</summary>
[CppInclude("Components/DMXPixelMappingOutputComponent.h")]
public partial class UDMXPixelMappingOutputComponent : UDMXPixelMappingBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>ZOrder in the UI</summary>
	public int ZOrder;
	///<summary>The color displayed in editor</summary>
	public FLinearColor EditorColor;
	///<summary>The quality level to use when averaging colors during downsampling.</summary>
	public EDMXPixelBlendingQuality CellBlendingQuality;
	///<summary>PositionX</summary>
	public float PositionX;
	///<summary>PositionY</summary>
	public float PositionY;
	///<summary>SizeX</summary>
	public float SizeX;
	///<summary>SizeY</summary>
	public float SizeY;
	///<summary>bLockInDesigner</summary>
	public bool bLockInDesigner;
	///<summary>bVisibleInDesigner</summary>
	public bool bVisibleInDesigner;
}
