namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXMVRFixtureActorInterface.h")]
public partial class UDMXMVRFixtureActorInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Should return the DMX Attributes the Actor supports</summary>
	public void OnMVRGetSupportedDMXAttributes(TArray<FName> OutAttributeNames,TArray<FName> OutMatrixAttributeNames) {}
}
