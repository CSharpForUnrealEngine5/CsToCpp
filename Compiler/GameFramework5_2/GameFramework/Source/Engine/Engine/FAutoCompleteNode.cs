#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Console.h")]
///<summary>Node for storing an auto-complete tree based on each char in the command.</summary>
public partial struct FAutoCompleteNode {
// AutoCompleteNode
	public int IndexChar;
	public TArray<int> AutoCompleteListIndices;
}
