namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectPersistentCollection.h")]
public partial struct FSmartObjectContainer {
	public FBox Bounds;
	public TArray<FSmartObjectCollectionEntry> CollectionEntries;
	public TMap<FSmartObjectHandle,FSoftObjectPath> RegisteredIdToObjectMap;
	public TArray<USmartObjectDefinition> Definitions;
	public UObject Owner;
}
