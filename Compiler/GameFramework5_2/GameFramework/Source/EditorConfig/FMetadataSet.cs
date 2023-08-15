namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorMetadataOverrides.h")]
public partial struct FMetadataSet {
	public TMap<FName,string> Strings;
	public TMap<FName,bool> Bools;
	public TMap<FName,int> Ints;
	public TMap<FName,float> Floats;
}
