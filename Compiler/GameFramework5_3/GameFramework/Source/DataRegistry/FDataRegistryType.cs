namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper struct to represent a global data registry, represented as an FName internally and implicitly convertible back and forth.</summary>
[CppInclude("DataRegistryId.h")]
public partial struct FDataRegistryType {
	public FName Name;
}
