namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Various fractal noises that can be used to filter points</summary>
[CppInclude("Elements/PCGSpatialNoise.h")]
public partial class UPCGSpatialNoiseSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The noise method used</summary>
	public PCGSpatialNoiseMode Mode;
	///<summary>EdgeMask2DMode</summary>
	public PCGSpatialNoiseMask2DMode EdgeMask2DMode;
	///<summary>this is how many times the fractal method recurses. A higher number will mean more detail</summary>
	public int Iterations;
	///<summary>if true, will generate results that tile along the bounding box size of the</summary>
	public bool bTiling;
	///<summary>Brightness</summary>
	public float Brightness;
	///<summary>Contrast</summary>
	public float Contrast;
	///<summary>The output attribute name to write, if not &#39;None&#39;</summary>
	public FPCGAttributePropertyOutputNoSourceSelector ValueTarget;
	///<summary>Adds a random amount of offset up to this amount</summary>
	public FVector RandomOffset;
	///<summary>this will apply a transform to the points before calculating noise</summary>
	public FTransform Transform;
	///<summary>the less random this is, the more it returns to being a grid</summary>
	public double VoronoiCellRandomness;
	///<summary>The output attribute name to write the voronoi cell id, if not &#39;None&#39;</summary>
	public FPCGAttributePropertyOutputNoSourceSelector VoronoiCellIDTarget;
	///<summary>If true it will orient the output points to point towards the cell edges, which can be used for effects</summary>
	public bool bVoronoiOrientSamplesToCellEdge;
	///<summary>The cell resolution of the tiled voronoi (across the bounds)</summary>
	public int TiledVoronoiResolution;
	///<summary>how many cells around the edge will tile</summary>
	public int TiledVoronoiEdgeBlendCellCount;
	///<summary>if &gt; 0, we blend to a tiling edge value</summary>
	public float EdgeBlendDistance;
	///<summary>Adjust the center point of the curve (where x = curve(x) crosses over)</summary>
	public float EdgeBlendCurveOffset;
	///<summary>will makes the falloff harsher or softer</summary>
	public float EdgeBlendCurveIntensity;
}
