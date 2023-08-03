#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/SnapshotTestActor.h")]
public partial class USubobject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>IntProperty</summary>
	public int IntProperty;
	///<summary>FloatProperty</summary>
	public float FloatProperty;
	///<summary>NestedChild</summary>
	public USubSubobject NestedChild;
	///<summary>UneditableNestedChild</summary>
	public USubSubobject UneditableNestedChild;
}
