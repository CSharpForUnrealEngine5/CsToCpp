#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds ability system attribute defaults from this game feature</summary>
[CppInclude("GameFeatureAction_AddAttributeDefaults.h")]
public partial class UGameFeatureAction_AddAttributeDefaults : UGameFeatureAction {
	///<summary>List of attribute default tables to add</summary>
	public TArray<FSoftObjectPath> AttribDefaultTableNames;
}
