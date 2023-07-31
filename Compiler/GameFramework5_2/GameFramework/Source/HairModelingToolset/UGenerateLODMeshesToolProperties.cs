#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Simplify operation</summary>
[CppInclude("GenerateLODMeshesTool.h")]
public partial class UGenerateLODMeshesToolProperties : UMeshConstraintProperties {
	///<summary>Simplification Target Type  //UPROPERTY(EditAnywhere, Category = Options)</summary>
	public ESimplifyTargetType TargetMode;
	///<summary>Simplification Scheme  //UPROPERTY(EditAnywhere, Category = Options)</summary>
	public ESimplifyType SimplifierType;
	///<summary>Output LOD Assets will be numbered starting at this number</summary>
	public int NameIndexBase;
	///<summary>Target percentage of original triangle count //UPROPERTY(EditAnywhere, Category = Options, meta = (UIMin = &quot;0&quot;, UIMax = &quot;100&quot;, EditCondition = &quot;TargetMode == ESimplifyTargetType::Percentage&quot;))</summary>
	public int TargetPercentage;
	///<summary>Target edge length //UPROPERTY(EditAnywhere, Category = Options, meta = (UIMin = &quot;3.0&quot;, UIMax = &quot;10.0&quot;, ClampMin = &quot;0.001&quot;, ClampMax = &quot;1000.0&quot;, EditCondition = &quot;TargetMode == ESimplifyTargetType::EdgeLength &amp;&amp; SimplifierType != ESimplifyType::UEStandard&quot;))</summary>
	public float TargetEdgeLength;
	///<summary>Target triangle/vertex count //UPROPERTY(EditAnywhere, Category = Options, meta = (UIMin = &quot;4&quot;, UIMax = &quot;10000&quot;, ClampMin = &quot;1&quot;, ClampMax = &quot;9999999999&quot;, EditCondition = &quot;TargetMode == ESimplifyTargetType::TriangleCount&quot;))</summary>
	public int TargetCount;
	///<summary>Discard UVs and existing normals, allowing the simplifier to ignore any UV and normal seams. New per-vertex normals are computed. //UPROPERTY(EditAnywhere, Category = Options)</summary>
	public bool bDiscardAttributes;
	///<summary>If true, display wireframe</summary>
	public bool bShowWireframe;
	///<summary>Display colors corresponding to the mesh&#39;s polygon groups //UPROPERTY(EditAnywhere, Category = Display)</summary>
	public bool bShowGroupColors;
	///<summary>Enable projection back to input mesh //UPROPERTY(EditAnywhere, Category = Options, AdvancedDisplay)</summary>
	public bool bReproject;
	///<summary>LODLevels</summary>
	public TArray<FLODLevelGenerateSettings> LODLevels;
}
