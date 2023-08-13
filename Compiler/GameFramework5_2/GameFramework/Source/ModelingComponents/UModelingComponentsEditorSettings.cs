namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor preferences for the Modeling Components plug-in.</summary>
[CppInclude("ModelingComponentsSettings.h")]
public partial class UModelingComponentsEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The type of grid to draw in the viewport for modeling mode tools</summary>
	public EModelingComponentsPlaneVisualizationMode GridMode;
	///<summary>The number of lines to be drawn for the plane</summary>
	public int NumGridLines;
	///<summary>The space between grid lines in world space</summary>
	public float GridSpacing;
	///<summary>The base scale used to determine the size of the hierarchical plane</summary>
	public float GridScale;
	///<summary>The fraction of the viewport that the grid should occupy if looking at the plane&#39;s center</summary>
	public float GridSize;
}
