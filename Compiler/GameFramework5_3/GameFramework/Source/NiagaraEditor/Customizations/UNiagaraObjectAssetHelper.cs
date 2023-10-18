namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Customizations/NiagaraComponentDetails.h")]
public partial class UNiagaraObjectAssetHelper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>We are customizing the instance property metadata for this to restrict the allowed classes in the UI</summary>
	public FSoftObjectPath Path;
}
