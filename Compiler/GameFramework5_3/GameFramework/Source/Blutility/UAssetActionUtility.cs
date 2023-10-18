namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all asset action-related utilities</summary>
[CppInclude("AssetActionUtility.h")]
public partial class UAssetActionUtility : UEditorUtilityObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetSupportedClass</summary>
	public UClass GetSupportedClass() { return default; }
	///<summary>Returns whether or not this action is designed to work specifically on Blueprints (true) or on all assets (false).</summary>
	public bool IsActionForBlueprints() { return default; }
	///<summary>Gets the statically determined supported classes, these classes are used as a first pass filter when determining</summary>
	public TArray<TSoftObjectPtr<UClass>> GetSupportedClasses() { return default; }
	///<summary>The supported classes controls the list of classes that may be operated on by all of the asset functions in this</summary>
	public TArray<TSoftObjectPtr<UClass>> SupportedClasses;
	///<summary>The supported conditions for any asset to use these utility functions.  Note: all of these conditions must pass</summary>
	public TArray<FAssetActionSupportCondition> SupportedConditions;
}
