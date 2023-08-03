#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SSkinWeightProfileImportOptions.h")]
public partial class USkinWeightImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the to-be-imported Skin Weights Profile</summary>
	public string ProfileName;
	///<summary>File path to FBX file containing Mesh with alternative set of Skin Weights</summary>
	public string FilePath;
	///<summary>Target LOD index this file corresponds to</summary>
	public int LODIndex;
}
