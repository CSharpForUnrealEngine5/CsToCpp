#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VectorField/VectorFieldStatic.h")]
public partial class UVectorFieldStatic : UVectorField {
	///<summary>Size of the vector field volume.</summary>
	public int SizeX;
	///<summary>Size of the vector field volume.</summary>
	public int SizeY;
	///<summary>Size of the vector field volume.</summary>
	public int SizeZ;
	///<summary>Whether to keep vector field data accessible to the CPU.</summary>
	public bool bAllowCPUAccess;
	///<summary>SourceFilePath_DEPRECATED</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
}
