namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/SnapshotTestActor.h")]
public partial class USnapshotTestComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>IntProperty</summary>
	public int IntProperty;
	///<summary>FloatProperty</summary>
	public float FloatProperty;
	///<summary>Subobject</summary>
	public USubobject Subobject;
}
