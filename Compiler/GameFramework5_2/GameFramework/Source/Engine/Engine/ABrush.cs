namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Brush.h")]
public partial class ABrush : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Type of brush</summary>
	public EBrushType BrushType;
	///<summary>Information.</summary>
	public FColor BrushColor;
	///<summary>PolyFlags</summary>
	public int PolyFlags;
	///<summary>bColored</summary>
	public bool bColored;
	///<summary>bSolidWhenSelected</summary>
	public bool bSolidWhenSelected;
	///<summary>If true, this brush class can be placed using the class browser like other simple class types</summary>
	public bool bPlaceableFromClassBrowser;
	///<summary>If true, this brush is a builder or otherwise does not need to be loaded into the game</summary>
	public bool bNotForClientOrServer;
	///<summary>Brush</summary>
	public UModel Brush;
	///<summary>BrushComponent</summary>
	public UBrushComponent BrushComponent;
	///<summary>BrushBuilder</summary>
	public UBrushBuilder BrushBuilder;
	///<summary>If true, display the brush with a shaded volume</summary>
	public bool bDisplayShadedVolume;
	///<summary>Value used to set the opacity for the shaded volume, between 0-1</summary>
	public float ShadedVolumeOpacityValue;
	///<summary>Flag set when we are in a manipulation (scaling, translation, brush builder param change etc.)</summary>
	public bool bInManipulation;
	///<summary>Stores selection information from geometry mode.  This is the only information that we can&#39;t</summary>
	public TArray<FGeomSelection> SavedSelections;
}
