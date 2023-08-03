#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for settings-as-data in the PCG framework</summary>
[CppInclude("PCGSettings.h")]
public partial class UPCGSettings : UPCGSettingsInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Seed</summary>
	public int Seed;
	///<summary>Warning - this is deprecated and will be removed soon since we have a Filter By Tag node for this specific purpose</summary>
	public TSet<string> FilterOnTags;
	///<summary>Warning - this is deprecated and will be removed soon since we have a Filter By Tag node for this specific purpose</summary>
	public bool bPassThroughFilteredOutInputs;
	///<summary>Applies the specified tags on the output data. Note - this might be replaced by a dedicated Tagging node</summary>
	public TSet<string> TagsAppliedOnOutput;
	///<summary>ExecutionMode_DEPRECATED</summary>
	public EPCGSettingsExecutionMode ExecutionMode_DEPRECATED;
	///<summary>DeterminismSettings</summary>
	public FPCGDeterminismSettings DeterminismSettings;
	///<summary>bExposeToLibrary</summary>
	public bool bExposeToLibrary;
	///<summary>Category</summary>
	public string Category;
	///<summary>Description</summary>
	public string Description;
	///<summary>By default, settings won&#39;t use a seed. Set this bool to true in the child ctor to allow edition and use it.</summary>
	public bool bUseSeed;
	///<summary>Needs to be serialized since property metadata (used to populate this array) is not available at runtime.</summary>
	public TArray<FPCGSettingsOverridableParam> CachedOverridableParams;
}
