using CSharpToCpp.Utilities;
using GameFramework;

namespace BlueprintLib;

public class UEdGraph : UObject
{
    public TArray<TObjectPtr<UEdGraphNode>> Nodes;
}