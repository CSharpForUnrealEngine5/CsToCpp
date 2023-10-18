namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds ability system attribute defaults from this game feature</summary>
[CppInclude("GameFeatureAction_AddAttributeDefaults.h")]
public partial class UGameFeatureAction_AddAttributeDefaults : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>List of attribute default tables to add</summary>
	public TArray<FSoftObjectPath> AttribDefaultTableNames;
}
