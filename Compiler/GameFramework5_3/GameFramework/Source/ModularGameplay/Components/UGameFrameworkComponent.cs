namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameFrameworkComponent is a base class for actor components made for the basic game framework classes.</summary>
[CppInclude("Components/GameFrameworkComponent.h")]
public partial class UGameFrameworkComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
}
