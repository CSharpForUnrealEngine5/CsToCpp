namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFactory.h")]
public partial class UMetaSoundBaseFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Set to initialize MetaSound type as Preset,</summary>
	public UObject ReferencedMetaSoundObject;
}
