#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxFactory.h")]
public partial class UFbxFactory : UFactory {
	///<summary>ImportUI</summary>
	public UFbxImportUI ImportUI;
	///<summary>Prevent garbage collection of original when overriding ImportUI property</summary>
	public UFbxImportUI OriginalImportUI;
}
