#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node for storing an auto-complete tree based on each char in the command.</summary>
[CppInclude("Engine/Console.h")]
public partial struct FAutoCompleteNode {
	public int IndexChar;
	public TArray<int> AutoCompleteListIndices;
}
