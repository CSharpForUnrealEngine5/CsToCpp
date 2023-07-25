#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceBindingReference.h")]
///<summary>Structure that stores a one to many mapping from object binding ID, to object references that pertain to that ID.</summary>
public partial struct FLevelSequenceBindingReferences {
// LevelSequenceBindingReferences
	public TMap<FGuid,FLevelSequenceBindingReferenceArray> BindingIdToReferences;
	public TSet<FGuid> AnimSequenceInstances;
	public TSet<FGuid> PostProcessInstances;
}
