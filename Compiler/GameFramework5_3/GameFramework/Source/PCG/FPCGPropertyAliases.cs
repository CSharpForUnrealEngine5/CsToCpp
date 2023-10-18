namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dummy struct to bypass the UHT limitation for array of arrays.</summary>
[CppInclude("PCGSettings.h")]
public partial struct FPCGPropertyAliases {
	public TArray<FName> Aliases;
}
