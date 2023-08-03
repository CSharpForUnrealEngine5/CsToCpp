#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USingleClickInputBehavior implements a standard &quot;button-click&quot;-style input behavior.</summary>
[CppInclude("BaseBehaviors/SingleClickBehavior.h")]
public partial class USingleClickInputBehavior : UAnyButtonInputBehavior {
	public static UClass StaticClass() {return default;}
	///<summary>Hit-test is repeated on release (standard behavior). If false,</summary>
	public bool HitTestOnRelease;
}
