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
