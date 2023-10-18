namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxFactory.h")]
public partial class UFbxFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>ImportUI</summary>
	public UFbxImportUI ImportUI;
	///<summary>Prevent garbage collection of original when overriding ImportUI property</summary>
	public UFbxImportUI OriginalImportUI;
}
