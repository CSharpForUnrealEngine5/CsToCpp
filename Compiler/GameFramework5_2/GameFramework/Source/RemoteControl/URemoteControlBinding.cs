#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Acts as a bridge between an exposed property/function and an object to act on.</summary>
[CppInclude("RemoteControlBinding.h")]
public partial class URemoteControlBinding : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of this binding. Defaults to the bound object&#39;s name.</summary>
	public string Name;
	///<summary>The path to the last object that was bound.</summary>
	public FSoftObjectPath LastBoundObjectPath;
}
