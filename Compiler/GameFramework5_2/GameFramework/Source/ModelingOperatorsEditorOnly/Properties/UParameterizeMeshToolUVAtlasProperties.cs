#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the UVAtlas Automatic UV Generation Method</summary>
[CppInclude("Properties/ParameterizeMeshProperties.h")]
public partial class UParameterizeMeshToolUVAtlasProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum amount of stretch, from none to unbounded. If zero stretch is specified, each triangle will likely be its own UV island.</summary>
	public float IslandStretch;
	///<summary>Hint at number of UV islands. The default of 0 means it is determined automatically.</summary>
	public int NumIslands;
	///<summary>Expected resolution of the output textures; this controls spacing left between UV islands to avoid interpolation artifacts.</summary>
	public int TextureResolution;
	///<summary>Generate new UVs based on polygroups from specified layer.</summary>
	public bool bUsePolygroups;
	///<summary>Layout resulting islands on UDIMs based on polygroups.</summary>
	public bool bLayoutUDIMPerPolygroup;
	///<summary>Controls if polygroup options are available to the user.</summary>
	public bool bPolygroupsEnabled;
	///<summary>Controls if UDIM options are available to the user.</summary>
	public bool bUDIMsEnabled;
}
