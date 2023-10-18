namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct that represents a single subobject. This can be anything, but are</summary>
[CppInclude("SubobjectData.h")]
public partial struct FSubobjectData {
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	public FSubobjectDataHandle Handle;
	public FSubobjectDataHandle ParentObjectHandle;
	public TArray<FSubobjectDataHandle> ChildrenHandles;
}
