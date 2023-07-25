#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectCollection.h")]
///<summary>Actor holding smart object persistent data</summary>
public partial class ADEPRECATED_SmartObjectCollection : AActor {
// SmartObjectCollection
	public FBox Bounds;
	public TArray<FSmartObjectCollectionEntry> CollectionEntries;
	public TMap<FSmartObjectHandle,FSoftObjectPath> RegisteredIdToObjectMap;
	public TArray<USmartObjectDefinition> Definitions;
	public bool bBuildOnDemand_DEPRECATED;
	public bool bBuildCollectionAutomatically;
}
