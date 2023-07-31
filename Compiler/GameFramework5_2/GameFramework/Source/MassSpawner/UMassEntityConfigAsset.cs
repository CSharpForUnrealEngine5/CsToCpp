#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Agent Config asset allows to create shared configs that can be used as base for derived configs.</summary>
[CppInclude("MassEntityConfigAsset.h")]
public partial class UMassEntityConfigAsset : UDataAsset {
	///<summary>ValidateEntityConfig</summary>
	public  void ValidateEntityConfig() {}
	///<summary>The config described in this asset.</summary>
	public FMassEntityConfig Config;
}
