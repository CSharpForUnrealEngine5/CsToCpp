#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RemoteControl Path segment holding a property layer</summary>
[CppInclude("RemoteControlFieldPath.h")]
public partial struct FRCFieldPathSegment {
	public string Name;
	public int ArrayIndex;
	public string ValuePropertyName;
	public string MapKey;
}
