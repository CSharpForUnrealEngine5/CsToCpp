namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/ParameterizeMeshProperties.h")]
public partial class UParameterizeMeshToolPatchBuilderProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Number of initial patches the mesh will be split into before island merging.</summary>
	public int InitialPatches;
	///<summary>Alignment of the initial patches to creases in the mesh.</summary>
	public float CurvatureAlignment;
	///<summary>Threshold for stretching and distortion below which island merging is allowed; larger values increase the allowable UV distortion.</summary>
	public float MergingDistortionThreshold;
	///<summary>Threshold for the average face normal deviation below which island merging is allowed.</summary>
	public float MergingAngleThreshold;
	///<summary>Number of smoothing steps to apply; this slightly increases distortion but produces more stable results.</summary>
	public int SmoothingSteps;
	///<summary>Smoothing parameter; larger values result in faster smoothing in each step.</summary>
	public float SmoothingAlpha;
	///<summary>Automatically pack result UVs into the unit square, i.e. fit between 0 and 1 with no overlap.</summary>
	public bool bRepack;
	///<summary>Expected resolution of the output textures; this controls spacing left between UV islands to avoid interpolation artifacts. This is only enabled when Repack is enabled.</summary>
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
