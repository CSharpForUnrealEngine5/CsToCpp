#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds exposed functions and properties.</summary>
[CppInclude("RemoteControlPreset.h")]
public partial class URemoteControlPreset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The visual layout for this preset.</summary>
	public FRemoteControlPresetLayout Layout;
	///<summary>This preset&#39;s metadata.</summary>
	public TMap<string,string> Metadata;
	///<summary>This preset&#39;s list of objects that are exposed or that have exposed fields.</summary>
	public TArray<URemoteControlBinding> Bindings;
	///<summary>Holds virtual controllers properties, behaviours and actions</summary>
	public URCVirtualPropertyContainerBase ControllerContainer;
	///<summary>Preset unique ID</summary>
	public FGuid PresetId;
	///<summary>The cache for information about an exposed field.</summary>
	public TMap<FGuid,FRCCachedFieldData> FieldCache;
	///<summary>Map of Field Name to GUID.</summary>
	public TMap<string,FGuid> NameToGuidMap;
	///<summary>Holds exposed entities on the preset.</summary>
	public URemoteControlExposeRegistry Registry;
	///<summary>DetailsTabIdentifierOverrides</summary>
	public TArray<string> DetailsTabIdentifierOverrides;
}
