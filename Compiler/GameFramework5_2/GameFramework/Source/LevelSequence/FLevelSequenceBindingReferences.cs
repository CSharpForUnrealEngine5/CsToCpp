namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that stores a one to many mapping from object binding ID, to object references that pertain to that ID.</summary>
[CppInclude("LevelSequenceBindingReference.h")]
public partial struct FLevelSequenceBindingReferences {
	public TMap<FGuid,FLevelSequenceBindingReferenceArray> BindingIdToReferences;
	public TSet<FGuid> AnimSequenceInstances;
	public TSet<FGuid> PostProcessInstances;
}
