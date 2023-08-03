#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor holding smart object persistent data</summary>
[CppInclude("SmartObjectCollection.h")]
public partial class ADEPRECATED_SmartObjectCollection : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>CollectionEntries</summary>
	public TArray<FSmartObjectCollectionEntry> CollectionEntries;
	///<summary>RegisteredIdToObjectMap</summary>
	public TMap<FSmartObjectHandle,FSoftObjectPath> RegisteredIdToObjectMap;
	///<summary>Definitions</summary>
	public TArray<USmartObjectDefinition> Definitions;
	///<summary>This property used to be exposed to the UI editor. It was replaced with bBuildCollectionAutomatically for greater readability.</summary>
	public bool bBuildOnDemand_DEPRECATED;
	///<summary>bBuildCollectionAutomatically</summary>
	public bool bBuildCollectionAutomatically;
}
