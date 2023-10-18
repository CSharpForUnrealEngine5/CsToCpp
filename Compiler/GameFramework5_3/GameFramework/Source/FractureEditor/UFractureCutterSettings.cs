namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings specifically related to the one-time destructive fracturing of a mesh *</summary>
[CppInclude("FractureToolCutter.h")]
public partial class UFractureCutterSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Material to set for internal faces on fracture. &#39;Automatic&#39; will use the most common &#39;internal&#39; material in each geometry, or the last valid material if no internal faces are found</summary>
	public string InternalMaterial;
	///<summary>GetMaterialNamesFunc</summary>
	public TArray<string> GetMaterialNamesFunc() { return default; }
	///<summary>Random number generator seed for repeatability. If the value is -1, a different random seed will be used every time, otherwise the specified seed will always be used</summary>
	public int RandomSeed;
	///<summary>Chance to fracture each selected bone. If 0, no bones will fracture; if 1, all bones will fracture.</summary>
	public float ChanceToFracture;
	///<summary>Generate a fracture pattern across all selected meshes.</summary>
	public bool bGroupFracture;
	///<summary>This flag allows tools to disable the above bGroupFracture option if/when it is not applicable</summary>
	public bool bGroupFractureToggleEnabled;
	///<summary>Amount of space to leave between cut pieces</summary>
	public float Grout;
	///<summary>This flag allows tools to disable the above Grout setting if/when it&#39;s not applicable</summary>
	public bool bGroutSettingEnabled;
	///<summary>Draw points marking the centers of pieces to be cut out by the fracture pattern.</summary>
	public bool bDrawSites;
	///<summary>This flag allows tools to disable the above bDrawSites option if/when it is not applicable</summary>
	public bool bDrawSitesToggleEnabled;
	///<summary>Draw the edges of the fracture pattern.</summary>
	public bool bDrawDiagram;
	///<summary>Whether to show a solid preview of the cutting geometry, including any noise displacement</summary>
	public bool bDrawNoisePreview;
	///<summary>This flag allows tools to disable the above bDrawNoisePreview option if/when it is not applicable</summary>
	public bool bNoisePreviewToggleEnabled;
	///<summary>Fraction of cells to show in noise preview</summary>
	public float FractionPreviewCells;
	///<summary>Scale of the noise preview plane</summary>
	public double NoisePreviewScale;
	///<summary>This flag allows tools to disable the noise preview scale setting if it&#39;s not applicable</summary>
	public bool bNoisePreviewHasScale;
	///<summary>Size of the Perlin noise displacement (in cm). If 0, no noise will be applied</summary>
	public float Amplitude;
	///<summary>Period of the Perlin noise.  Smaller values will create a smoother noise pattern</summary>
	public float Frequency;
	///<summary>Persistence of the layers of Perlin noise. At each layer (octave) after the first, the amplitude of the Perlin noise is scaled by this factor</summary>
	public float Persistence;
	///<summary>Lacunarity of the layers of Perlin noise. At each layer (octave) after the first, the frequency of the Perlin noise is scaled by this factor</summary>
	public float Lacunarity;
	///<summary>Number of fractal layers of Perlin noise to apply. Each layer is additive, with Amplitude and Frequency parameters scaled by Persistence and Lacunarity</summary>
	public int OctaveNumber;
	///<summary>Distance (in cm) between vertices on cut surfaces where noise is added.  Larger spacing between vertices will create more efficient meshes with fewer triangles, but less resolution to see the shape of the added noise</summary>
	public float PointSpacing;
	///<summary>This flag allows tools to disable the above Noise settings if/when they are not applicable</summary>
	public bool bNoiseSettingsEnabled;
	///<summary>ActiveMaterialNamesList</summary>
	public TArray<string> ActiveMaterialNamesList;
}
