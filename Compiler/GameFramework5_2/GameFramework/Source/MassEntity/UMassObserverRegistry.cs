#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassObserverRegistry.h")]
public partial class UMassObserverRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FragmentObservers</summary>
	public FMassEntityObserverClassesMap FragmentObservers;
	///<summary>TagObservers</summary>
	public FMassEntityObserverClassesMap TagObservers;
}
