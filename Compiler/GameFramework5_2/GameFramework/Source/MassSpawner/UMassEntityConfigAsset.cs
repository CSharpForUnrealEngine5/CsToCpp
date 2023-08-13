namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Agent Config asset allows to create shared configs that can be used as base for derived configs.</summary>
[CppInclude("MassEntityConfigAsset.h")]
public partial class UMassEntityConfigAsset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>ValidateEntityConfig</summary>
	public void ValidateEntityConfig() {}
	///<summary>The config described in this asset.</summary>
	public FMassEntityConfig Config;
}
