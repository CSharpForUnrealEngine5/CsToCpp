namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DNAAssetImportUI.h")]
public partial class UDNAAssetImportUI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Skeletal mesh to use for imported DNA asset. When importing DNA, leaving this as &quot;None&quot; will generate new skeletal mesh.</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>ResetToDefault</summary>
	public void ResetToDefault() {}
	///<summary>The DNA file name</summary>
	public string FileName;
}
