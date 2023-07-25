#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectData.h")]
///<summary>A struct that represents a single subobject. This can be anything, but are</summary>
public partial struct FSubobjectData {
// SubobjectData
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	public FSubobjectDataHandle Handle;
	public FSubobjectDataHandle ParentObjectHandle;
	public TArray<FSubobjectDataHandle> ChildrenHandles;
}
