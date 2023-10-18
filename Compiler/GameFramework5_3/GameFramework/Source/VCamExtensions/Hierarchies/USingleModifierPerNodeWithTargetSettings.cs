namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/TargetModifierPerNodeHierarchyRules.h")]
public partial class USingleModifierPerNodeWithTargetSettings : UBaseModifierGroup {
	public static UClass StaticClass() {return default;}
	///<summary>TargetSettings</summary>
	public FVCamConnectionTargetSettings TargetSettings;
	///<summary>ChildElements</summary>
	public TArray<USingleModifierPerNodeWithTargetSettings> ChildElements;
}
