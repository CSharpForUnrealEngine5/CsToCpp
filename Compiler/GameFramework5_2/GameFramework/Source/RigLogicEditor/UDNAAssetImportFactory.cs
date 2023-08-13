namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory responsible for importing DNA file and attaching DNA data into SkeletalMesh</summary>
[CppInclude("DNAAssetImportFactory.h")]
public partial class UDNAAssetImportFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>ImportUI</summary>
	public UDNAAssetImportUI ImportUI;
	///<summary>Prevent garbage collection of original when overriding ImportUI property</summary>
	public UDNAAssetImportUI OriginalImportUI;
}
