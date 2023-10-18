using CSharpToCpp.Utilities;
using GameFramework;

namespace BlueprintLib;

public class UEdGraphNode : UObject
{
    TArray<UEdGraphPin> Pins;

    public string NodeComment = "";
}