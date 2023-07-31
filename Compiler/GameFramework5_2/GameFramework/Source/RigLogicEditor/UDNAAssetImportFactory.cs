#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory responsible for importing DNA file and attaching DNA data into SkeletalMesh</summary>
[CppInclude("DNAAssetImportFactory.h")]
public partial class UDNAAssetImportFactory : UFactory {
	///<summary>ImportUI</summary>
	public UDNAAssetImportUI ImportUI;
	///<summary>Prevent garbage collection of original when overriding ImportUI property</summary>
	public UDNAAssetImportUI OriginalImportUI;
}
