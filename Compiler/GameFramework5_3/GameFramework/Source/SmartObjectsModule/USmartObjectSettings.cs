namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSettings.h")]
public partial class USmartObjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Default filtering policy to use for TagQueries applied on User Tags in newly created SmartObjectDefinitions.</summary>
	public ESmartObjectTagFilteringPolicy DefaultUserTagsFilteringPolicy;
	///<summary>Default merging policy to use for Activity Tags in newly created SmartObjectDefinitions.</summary>
	public ESmartObjectTagMergingPolicy DefaultActivityTagsMergingPolicy;
	///<summary>Base world condition class for all new Smart Object definitions.</summary>
	public UClass DefaultWorldConditionSchemaClass;
}
