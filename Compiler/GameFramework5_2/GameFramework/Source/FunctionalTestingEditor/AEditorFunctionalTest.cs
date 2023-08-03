#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor-only version of functional test actor, tests that call editor-only blueprints must inherit from this class</summary>
[CppInclude("EditorFunctionalTest.h")]
public partial class AEditorFunctionalTest : AFunctionalTest {
	public static UClass StaticClass() {return default;}
}
