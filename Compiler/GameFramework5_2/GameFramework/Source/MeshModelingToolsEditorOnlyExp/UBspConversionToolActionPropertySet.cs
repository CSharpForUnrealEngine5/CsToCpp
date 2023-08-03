#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BspConversionTool.h")]
public partial class UBspConversionToolActionPropertySet : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Select all brushes that satisfy the current settings.</summary>
	public  void SelectAllValidBrushes() {}
	///<summary>Deselect any currently selected volume brushes.</summary>
	public  void DeselectVolumes() {}
	///<summary>Deselect any currently selected brushes that are not valid targets given current settings.</summary>
	public  void DeselectNonValid() {}
}
