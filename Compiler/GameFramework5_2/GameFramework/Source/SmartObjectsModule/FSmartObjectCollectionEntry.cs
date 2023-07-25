#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectPersistentCollection.h")]
///<summary>Struct representing a unique registered component in the collection actor</summary>
public partial struct FSmartObjectCollectionEntry {
// SmartObjectCollectionEntry
	public FGameplayTagContainer Tags;
	public FSoftObjectPath Path;
	public FTransform Transform;
	public FBox Bounds;
	public FSmartObjectHandle Handle;
	public uint DefinitionIdx;
}
