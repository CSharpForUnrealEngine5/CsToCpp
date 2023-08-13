namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorMetadataOverrides.h")]
public partial struct FMetadataSet {
	public TMap<string,string> Strings;
	public TMap<string,bool> Bools;
	public TMap<string,int> Ints;
	public TMap<string,float> Floats;
}
