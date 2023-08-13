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
