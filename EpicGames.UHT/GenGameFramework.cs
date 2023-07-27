using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EpicGames.UHT.Types;

namespace EpicGames.UHT;

internal class GenGameFramework
{
	static readonly string GameFrameworkPath =
		@"C:\UnrealEngine\CSharpForUnrealEngine5\CsFirstPerson\Plugins\CsToCpp\Compiler\GameFramework5_2\GameFramework\Source\";


	internal static List<string> GenStart(UhtHeaderFile HeaderFile)
	{
		List<string> text = new();
		text.Add("#pragma warning disable CS8618,CS8603");
		text.Add("namespace GameFramework;");
		text.Add("using CSharpToCpp.Utilities;");
		text.Add($"[CppInclude(\"{HeaderFile.IncludeFilePath}\")]");
		return text;

	}
	static string GetType(UhtType ty) =>
		ty switch
		{
			UhtStrProperty _ or
			UhtTextProperty _ or
			UhtNameProperty _ => "string",
			UhtInt16Property _ => "short",
			UhtInt8Property _ => "short",
			UhtInt64Property _ => "long",
			UhtIntProperty _ => "int",
			UhtUInt16Property _ => "ushort",
			UhtUInt64Property _ => "ulong",
			UhtUInt32Property _ => "uint",
			UhtBoolProperty _ => "bool",
			UhtByteProperty _ => "byte",
			UhtFloatProperty _ => "float",
			UhtDoubleProperty _ => "double",
			UhtStructProperty stp => stp.ScriptStruct.SourceName,
			UhtEnumProperty ep => ep.Enum.SourceName,
			UhtObjectPtrProperty uhtObjectPtrProperty => uhtObjectPtrProperty.Class.SourceName,
			UhtLazyObjectPtrProperty uhtLazyObjectPtrProperty => $"TLazyObjectPtr<{uhtLazyObjectPtrProperty.Class.SourceName}>",
			UhtSoftObjectProperty uhtSoftObjectProperty => $"TSoftObjectPtr<{uhtSoftObjectProperty.Class.SourceName}>",
			UhtClassProperty uhtClassProperty => uhtClassProperty.Class.SourceName,
			//UhtClassPtrProperty uhtClassPtrProperty => uhtClassPtrProperty.ToString(),
			UhtWeakObjectPtrProperty uhtWeakObjectPtrProperty => $"TWeakObjectPtr<{uhtWeakObjectPtrProperty.Class.SourceName}>",
			UhtMapProperty uhtMapProperty => $"TMap<{GetType(uhtMapProperty.KeyProperty)},{GetType(uhtMapProperty.ValueProperty)}>",
			UhtArrayProperty uhtArrayProperty => $"TArray<{GetType(uhtArrayProperty.ValueProperty)}>",
			UhtSetProperty uhtSetProperty => $"TSet<{GetType(uhtSetProperty.ValueProperty)}>",
			UhtDelegateProperty uhtDelegateProperty => uhtDelegateProperty.Function.SourceName,
			UhtMulticastInlineDelegateProperty uhtDelegateProperty => uhtDelegateProperty.Function.SourceName,
			UhtMulticastSparseDelegateProperty uhtDelegateProperty => uhtDelegateProperty.Function.SourceName,
			UhtMulticastDelegateProperty uhtDelegateProperty => uhtDelegateProperty.Function.SourceName,
			UhtInterfaceProperty uhtInterfaceProperty => $"object /*{uhtInterfaceProperty.SourceName}*/",
			UhtObjectProperty objProp => objProp.Class.SourceName,
			UhtFieldPathProperty _ => "object",
			UhtFunction func => $"object /*{func.SourceName}*/",
			UhtLargeWorldCoordinatesRealProperty _ => "double",
			_ => throw new NotImplementedException()

		};

	static List<string> GenTooltip(List<string> text, UhtField Field)
	{
		if (Field.MetaData.ContainsKey("ToolTip"))
		{
			string toolTip = Field.MetaData.GetValueOrDefault("ToolTip");
			string[] fields = toolTip.Split("@note");
			fields = fields[0].Split("\n");
			text.Add($"///<summary>{fields[0].Replace("\r", "")}</summary>");
		}
		return text;
	}

	static void WriteToFile(List<string> text, UhtField Field, UhtHeaderFile headerFile)
	{
		string[] fields3 = headerFile.Package.Package.EngineName.Split("/");
		string package = fields3[2];
		string fileName = Field.SourceName;
		string[] fields2 = headerFile.IncludeFilePath.Split("/");
		string FilePath = "";
		if (!fileName.Contains(" "))
		{
			if (fields2.Length >= 2)
			{
				FilePath = $"{package}/{fields2[0]}/{fileName}.cs";
			}
			else
			{
				FilePath = $"{package}/{fileName}.cs";
			}
			string FullFilePath = Path.Combine(GameFrameworkPath, FilePath);
			string DirectoryPath = Path.GetDirectoryName(FullFilePath);
			if (!Directory.Exists(DirectoryPath))
			{
				Directory.CreateDirectory(DirectoryPath);
			}
			try
			{
				File.WriteAllLines(FullFilePath, text);
			} catch {
				ConsoleColor fc = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"Couldn't write {FullFilePath}");
				Console.ForegroundColor = fc;
			}
		}
	}

	static HashSet<string> delegates = new();
	internal static void GenDelegate(UhtFunction function)
	{
		if (delegates.Contains(function.SourceName))
			return;
		delegates.Add(function.SourceName);
		List<string> text = GenStart(function.HeaderFile);
		text = GenTooltip(text, function);
		if (function.EngineName.Contains("Delegate"))
		{
			text.Add($"public partial struct {function.GetDisplayNameText()} {{");
			text.Add($"// {function.EngineName}");
			text.Add("\tvoid AddDynamic(object obj, string functionName) {}");
			text.Add("}");
			WriteToFile(text, function, function.HeaderFile);
		}
		else
		{
			throw new NotImplementedException();
		}
	}

	internal static void GenEnum(UhtEnum enumObj)
	{
		bool isNamespaced = enumObj.CppType.EndsWith("::Type");
		List<string> text = GenStart(enumObj.HeaderFile);
		text = GenTooltip(text, enumObj);
		if (isNamespaced)
		{
			text.Add("[CppEnumInNamespace]");
		}
		text.Add($"public enum {enumObj.EngineName} {{");
		foreach (UhtEnumValue val in enumObj.EnumValues)
		{
			string valName =  val.Name.Contains("::") ? val.Name.Split("::")[1] :val.Name;
			long valValue = val.Value;
			text.Add($"\t{valName}={valValue},");
		}
		text.Add("}");
		UhtHeaderFile headerFile = enumObj.HeaderFile;
		WriteToFile(text, enumObj, headerFile);
		int x = 3;

	}

	internal static void GenScriptStruct(UhtScriptStruct scriptStruct)
	{
		List<string> text = GenStart(scriptStruct.HeaderFile);
		text = GenTooltip(text, scriptStruct);
		text.Add($"public partial struct {scriptStruct.SourceName} {{");
		text.Add($"// {scriptStruct.EngineName}");
		foreach (UhtType field in scriptStruct.Children)
		{
			if (field is UhtFunction)
			{
				throw new NotSupportedException();
			}
			string fieldText = GetType(field);
			string fieldName = field.SourceName;
			if (fieldName == "params")
				fieldName = "@params";
			fieldText = $"\tpublic {fieldText} {fieldName};";
			text.Add(fieldText);
		}
		text.Add("}");
		WriteToFile(text, scriptStruct, scriptStruct.HeaderFile);
	}
	internal static void GenClass(UhtClass classObj)
	{
		List<string> text = GenStart(classObj.HeaderFile);
		text = GenTooltip(text, classObj);
		string baseName = classObj.SuperClass?.SourceName;
		string baseClass = baseName != null ? $": {baseName}" : "";
		text.Add($"public partial class {classObj.SourceName} {baseClass} {{");
		text.Add($"// {classObj.EngineName}");
		foreach (UhtType field in classObj.Children)
		{
			if (field is UhtFunction func)
			{
				string name = field.SourceName;
				if (name.StartsWith('~'))
					continue;
				List<string> parameters = new();
				foreach (UhtType child in func.Children)
				{
					string paramType = GetType(child);
					string paramName = child.SourceName;
					if (paramName == "ReturnValue")
						continue;
					UhtProperty prop = (UhtProperty)child;
					string initText = "";
					if (prop != null && prop.DefaultValueTokens != null)
					{
						IEnumerable<string> tokens = from dv in prop.DefaultValueTokens select dv.ToString();

						string valueText = String.Join("",tokens);
#pragma warning disable CA1307
						valueText = valueText
										.Replace("nullPtr", "null")
										.Replace(".f", ".0f")
										.Replace(".e", ".0e")
										.Replace("::", ".");
						if (valueText[0] == 'F' && valueText.Contains('('))
							valueText = $"new {valueText}";
						if (paramType == "float" && !valueText.EndsWith("f",StringComparison.OrdinalIgnoreCase))
							valueText += 'f';
#pragma warning restore CA1307
						initText = $"/*={valueText}*/";
					}
					parameters.Add($"{paramType} {paramName}{initText}");
				}
				string p = String.Join(",", parameters);
				string retType = "void";
				string retBody = "{}";
				string staticKW = "";
				if (func.FunctionExportFlags.HasFlag(UhtFunctionExportFlags.CppStatic))
				{
					staticKW = "static";
				}
				if (func.ReturnProperty != null)
				{
					retType = GetType(func.ReturnProperty);
					retBody = "{ return default; }";
				}
				text.Add($"\tpublic {staticKW} {retType} {name}({p}) {retBody}");
			} else
			{
				string fieldText = GetType(field);
				string fieldName = field.SourceName;
				if (fieldName == "params")
					fieldName = "@params";
				fieldText = $"\tpublic {fieldText} {fieldName};";
				text.Add(fieldText);
			}
		}
		text.Add("}");
		WriteToFile(text, classObj, classObj.HeaderFile);
	}
}
