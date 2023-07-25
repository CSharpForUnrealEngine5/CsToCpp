#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCutter.h")]
///<summary>Settings specifically related to the one-time destructive fracturing of a mesh *</summary>
public partial class UFractureCutterSettings : UFractureToolSettings {
// FractureCutterSettings
	public int RandomSeed;
	public float ChanceToFracture;
	public bool bGroupFracture;
	public bool bGroupFractureToggleEnabled;
	public float Grout;
	public bool bGroutSettingEnabled;
	public bool bDrawSites;
	public bool bDrawSitesToggleEnabled;
	public bool bDrawDiagram;
	public bool bDrawNoisePreview;
	public bool bNoisePreviewToggleEnabled;
	public float FractionPreviewCells;
	public double NoisePreviewScale;
	public bool bNoisePreviewHasScale;
	public float Amplitude;
	public float Frequency;
	public float Persistence;
	public float Lacunarity;
	public int OctaveNumber;
	public float PointSpacing;
	public bool bNoiseSettingsEnabled;
}
