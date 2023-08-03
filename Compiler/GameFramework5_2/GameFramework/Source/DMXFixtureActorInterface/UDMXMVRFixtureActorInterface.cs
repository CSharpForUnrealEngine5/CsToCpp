#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXMVRFixtureActorInterface.h")]
public partial class UDMXMVRFixtureActorInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Should return the DMX Attributes the Actor supports</summary>
	public  void OnMVRGetSupportedDMXAttributes(TArray<string> OutAttributeNames,TArray<string> OutMatrixAttributeNames) {}
}
