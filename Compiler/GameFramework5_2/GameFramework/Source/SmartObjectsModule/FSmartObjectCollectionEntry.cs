#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing a unique registered component in the collection actor</summary>
[CppInclude("SmartObjectPersistentCollection.h")]
public partial struct FSmartObjectCollectionEntry {
	public FGameplayTagContainer Tags;
	public FSoftObjectPath Path;
	public FTransform Transform;
	public FBox Bounds;
	public FSmartObjectHandle Handle;
	public uint DefinitionIdx;
}
