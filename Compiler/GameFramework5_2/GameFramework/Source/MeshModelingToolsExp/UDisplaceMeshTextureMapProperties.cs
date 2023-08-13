namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PropertySet for properties affecting the Image Map displacement type.</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshTextureMapProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Displacement map. Only the first channel is used.</summary>
	public UTexture2D DisplacementMap;
	///<summary>Channel in the displacement map to use.</summary>
	public EDisplaceMeshToolChannelType Channel;
	///<summary>The value in the texture map that corresponds to no displacement. For instance, if set to 0, then all</summary>
	public float DisplacementMapBaseValue;
	///<summary>When sampling from the texture map, how to scale the mesh UV&#39;s in the x and y directions. For a mesh with</summary>
	public FVector2D UVScale;
	///<summary>When sampling from the texture map, how to offset the mesh UV&#39;s. This will result in offsetting the</summary>
	public FVector2D UVOffset;
	///<summary>When true, applies a function to remap the values in the displacement map, which can be used</summary>
	public bool bApplyAdjustmentCurve;
	///<summary>This curve is queried in the range [0,1] to adjust contrast of the displacement map.</summary>
	public UCurveFloat AdjustmentCurve;
	///<summary>Recalculate normals from displaced mesh. Disable this if you are applying Displacements that are paired with an existing Normal Map in your Material.</summary>
	public bool bRecalcNormals;
}
