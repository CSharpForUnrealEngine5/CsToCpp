namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builder in charge of building a MetaSound Patch</summary>
[CppInclude("MetasoundBuilderSubsystem.h")]
public partial class UMetaSoundPatchBuilder : UMetaSoundBuilderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Build</summary>
	public virtual object /*ReturnValue*/ Build(UObject Parent,FMetaSoundBuilderOptions Options) { return default; }
}
