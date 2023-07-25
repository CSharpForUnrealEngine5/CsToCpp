#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Brush.h")]
public partial class ABrush : AActor {
// Brush
	public byte BrushType;
	public FColor BrushColor;
	public int PolyFlags;
	public bool bColored;
	public bool bSolidWhenSelected;
	public bool bPlaceableFromClassBrowser;
	public bool bNotForClientOrServer;
	public UModel Brush;
	public UBrushComponent BrushComponent;
	public UBrushBuilder BrushBuilder;
	public bool bDisplayShadedVolume;
	public float ShadedVolumeOpacityValue;
	public bool bInManipulation;
	public TArray<FGeomSelection> SavedSelections;
}
