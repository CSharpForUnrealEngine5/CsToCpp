namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintTool.h")]
public partial class UMeshVertexPaintToolUtilityActions : UMeshVertexPaintToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Operation to apply to current Vertex Colors</summary>
	public EMeshVertexPaintToolUtilityOperations Operation;
	///<summary>SourceChannel</summary>
	public EMeshVertexPaintColorChannel SourceChannel;
	///<summary>SourceValue</summary>
	public float SourceValue;
	///<summary>Target Vertex Weight Map</summary>
	public FName WeightMap;
	///<summary>this function is called provide set of available weight maps</summary>
	public TArray<string> GetWeightMapsFunc() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> WeightMapsList;
	///<summary>TargetChannels</summary>
	public FModelingToolsColorChannelFilter TargetChannels;
	///<summary>TargetChannel</summary>
	public EMeshVertexPaintColorChannel TargetChannel;
	///<summary>Copy colors to HiRes Source Mesh, if it exists</summary>
	public bool bCopyToHiRes;
	///<summary>Target LOD to copy Colors to</summary>
	public string CopyToLODName;
	///<summary>GetLODNamesFunc</summary>
	public TArray<string> GetLODNamesFunc() { return default; }
	///<summary>LODNamesList</summary>
	public TArray<string> LODNamesList;
	///<summary>Apply the Operation currently selected below</summary>
	public void ApplySelectedOperation() {}
}
