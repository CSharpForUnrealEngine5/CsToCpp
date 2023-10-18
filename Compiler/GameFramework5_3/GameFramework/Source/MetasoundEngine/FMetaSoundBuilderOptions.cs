namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundBuilderSubsystem.h")]
public partial struct FMetaSoundBuilderOptions {
	public FName Name;
	public bool bForceUniqueClassName;
	public bool bAddToRegistry;
	public object /*ExistingMetaSound*/ ExistingMetaSound;
}
