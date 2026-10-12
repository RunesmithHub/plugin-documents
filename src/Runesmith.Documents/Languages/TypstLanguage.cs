using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.Documents.Languages;

/// <summary>Typst: its files, highlighting, comments and brackets.</summary>
public sealed class TypstLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Typst { get; } = new("typst", "Typst")
    {
        Extensions = [".typ"],
        ScopeName = "source.typst",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('[', ']'), ('{', '}'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition TypstGrammar { get; } = GrammarFiles.Find("source.typst", "typst/typst.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceTypstCodeGrammar { get; } = GrammarFiles.Find("source.typst-code", "typst/typst-code.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition MarkdownTypstCodeblockGrammar { get; } = GrammarFiles.Find("markdown.typst.codeblock", "typst/typst-markdown-injection.json");
}
