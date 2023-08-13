namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Create a simple asset that stores data related to a particular system in an instance of this class.</summary>
[CppInclude("Engine/DataAsset.h")]
public partial class UDataAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NativeClass</summary>
	public UClass NativeClass;
}
