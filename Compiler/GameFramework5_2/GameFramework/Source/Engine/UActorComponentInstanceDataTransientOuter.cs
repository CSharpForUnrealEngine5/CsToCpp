namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dummy class to use as an outer as we can instantiate a UObject since it is abstract class.</summary>
[CppInclude("ComponentInstanceDataCache.h")]
public partial class UActorComponentInstanceDataTransientOuter : UObject {
	public static UClass StaticClass() {return default;}
}
