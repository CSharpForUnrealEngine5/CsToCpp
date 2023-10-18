namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpeedTreeImportData.h")]
public partial class USpeedTreeImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>Specify the tree scale</summary>
	public float TreeScale;
	///<summary>Choose whether to import as a 3D asset, billboard or both</summary>
	public EImportGeometryType ImportGeometryType;
	///<summary>Choose whether painted foliage or individual actor</summary>
	public EImportLODType LODType;
	///<summary>IncludeCollision</summary>
	public bool IncludeCollision;
	///<summary>MakeMaterialsCheck</summary>
	public bool MakeMaterialsCheck;
	///<summary>IncludeNormalMapCheck</summary>
	public bool IncludeNormalMapCheck;
	///<summary>IncludeDetailMapCheck</summary>
	public bool IncludeDetailMapCheck;
	///<summary>IncludeSpecularMapCheck</summary>
	public bool IncludeSpecularMapCheck;
	///<summary>IncludeBranchSeamSmoothing</summary>
	public bool IncludeBranchSeamSmoothing;
	///<summary>IncludeSpeedTreeAO</summary>
	public bool IncludeSpeedTreeAO;
	///<summary>IncludeColorAdjustment</summary>
	public bool IncludeColorAdjustment;
	///<summary>IncludeSubsurface</summary>
	public bool IncludeSubsurface;
	///<summary>IncludeVertexProcessingCheck</summary>
	public bool IncludeVertexProcessingCheck;
	///<summary>IncludeWindCheck</summary>
	public bool IncludeWindCheck;
	///<summary>IncludeSmoothLODCheck</summary>
	public bool IncludeSmoothLODCheck;
}
