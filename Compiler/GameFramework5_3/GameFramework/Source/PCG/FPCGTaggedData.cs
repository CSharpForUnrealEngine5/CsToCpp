namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial struct FPCGTaggedData {
	public UPCGData Data;
	public TSet<string> Tags;
	public FName Pin;
	public bool bPinlessData;
}
