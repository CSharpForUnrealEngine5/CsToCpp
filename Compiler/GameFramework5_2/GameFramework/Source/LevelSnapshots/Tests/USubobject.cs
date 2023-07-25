#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/SnapshotTestActor.h")]
public partial class USubobject : UObject {
// Subobject
	public int IntProperty;
	public float FloatProperty;
	public USubSubobject NestedChild;
	public USubSubobject UneditableNestedChild;
}
