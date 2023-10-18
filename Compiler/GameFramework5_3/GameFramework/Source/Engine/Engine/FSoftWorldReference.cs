namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple wrapper type to enable content-defined structs to hold soft references to UWorld assets *</summary>
[CppInclude("Engine/SoftWorldReference.h")]
public partial struct FSoftWorldReference {
	public TSoftObjectPtr<UWorld> WorldAsset;
}
