namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The basic set of properties shared by (more or less) all DisplacementTypes.</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshCommonProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Displacement type</summary>
	public EDisplaceMeshToolDisplaceType DisplacementType;
	///<summary>Displacement intensity</summary>
	public float DisplaceIntensity;
	///<summary>Seed for randomization</summary>
	public int RandomSeed;
	///<summary>Type of the  mesh subdivision.</summary>
	public EDisplaceMeshToolSubdivisionType SubdivisionType;
	///<summary>Number of times to subdivide the mesh before displacing it.</summary>
	public int Subdivisions;
	///<summary>Select vertex weight map. If configured, the weight map value will be sampled to modulate displacement intensity.</summary>
	public string WeightMap;
	///<summary>GetWeightMapsFunc</summary>
	public TArray<string> GetWeightMapsFunc() { return default; }
	///<summary>WeightMapsList</summary>
	public TArray<string> WeightMapsList;
	///<summary>bInvertWeightMap</summary>
	public bool bInvertWeightMap;
	///<summary>bShowWireframe</summary>
	public bool bShowWireframe;
	///<summary>bDisableSizeWarning</summary>
	public bool bDisableSizeWarning;
}
