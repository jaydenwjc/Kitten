//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\users\ddong\documents\visual studio 2015\Projects\Kitten\Kitten\KittenGrammar.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Kitten {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class KittenGrammarLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, IntegerLiteral=20, BooleanLiteral=21, StringLiteral=22, 
		ID=23, WS=24;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "IntegerLiteral", "BooleanLiteral", "StringLiteral", 
		"ESC", "ID", "WS"
	};


	public KittenGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'='", "';'", "'('", "')'", "'*'", "'/'", "'+'", "'-'", 
		"'=='", "'>='", "'<='", "'!='", "'>'", "'<'", "'['", "'}'", "'{'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "IntegerLiteral", "BooleanLiteral", 
		"StringLiteral", "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "KittenGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1A\x8A\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3"+
		"\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3"+
		"\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x6\x15\x63\n\x15"+
		"\r\x15\xE\x15\x64\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3"+
		"\x16\x3\x16\x5\x16p\n\x16\x3\x17\x3\x17\x3\x17\a\x17u\n\x17\f\x17\xE\x17"+
		"x\v\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x5\x18\x80\n\x18\x3"+
		"\x19\x6\x19\x83\n\x19\r\x19\xE\x19\x84\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"v\x2\x2\x1B\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11"+
		"\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2"+
		"\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x2\x31"+
		"\x2\x19\x33\x2\x1A\x3\x2\x5\x3\x2\x32;\x4\x2\x43\\\x63|\x5\x2\f\f\xF\xF"+
		"\"\"\x8E\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3"+
		"\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3"+
		"\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2"+
		"\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2"+
		"\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2"+
		")\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x3\x35\x3\x2\x2\x2\x5\x39\x3\x2\x2\x2\a;\x3\x2\x2\x2\t=\x3"+
		"\x2\x2\x2\v?\x3\x2\x2\x2\r\x41\x3\x2\x2\x2\xF\x43\x3\x2\x2\x2\x11\x45"+
		"\x3\x2\x2\x2\x13G\x3\x2\x2\x2\x15I\x3\x2\x2\x2\x17L\x3\x2\x2\x2\x19O\x3"+
		"\x2\x2\x2\x1BR\x3\x2\x2\x2\x1DU\x3\x2\x2\x2\x1FW\x3\x2\x2\x2!Y\x3\x2\x2"+
		"\x2#[\x3\x2\x2\x2%]\x3\x2\x2\x2\'_\x3\x2\x2\x2)\x62\x3\x2\x2\x2+o\x3\x2"+
		"\x2\x2-q\x3\x2\x2\x2/\x7F\x3\x2\x2\x2\x31\x82\x3\x2\x2\x2\x33\x86\x3\x2"+
		"\x2\x2\x35\x36\ax\x2\x2\x36\x37\a\x63\x2\x2\x37\x38\at\x2\x2\x38\x4\x3"+
		"\x2\x2\x2\x39:\a?\x2\x2:\x6\x3\x2\x2\x2;<\a=\x2\x2<\b\x3\x2\x2\x2=>\a"+
		"*\x2\x2>\n\x3\x2\x2\x2?@\a+\x2\x2@\f\x3\x2\x2\x2\x41\x42\a,\x2\x2\x42"+
		"\xE\x3\x2\x2\x2\x43\x44\a\x31\x2\x2\x44\x10\x3\x2\x2\x2\x45\x46\a-\x2"+
		"\x2\x46\x12\x3\x2\x2\x2GH\a/\x2\x2H\x14\x3\x2\x2\x2IJ\a?\x2\x2JK\a?\x2"+
		"\x2K\x16\x3\x2\x2\x2LM\a@\x2\x2MN\a?\x2\x2N\x18\x3\x2\x2\x2OP\a>\x2\x2"+
		"PQ\a?\x2\x2Q\x1A\x3\x2\x2\x2RS\a#\x2\x2ST\a?\x2\x2T\x1C\x3\x2\x2\x2UV"+
		"\a@\x2\x2V\x1E\x3\x2\x2\x2WX\a>\x2\x2X \x3\x2\x2\x2YZ\a]\x2\x2Z\"\x3\x2"+
		"\x2\x2[\\\a\x7F\x2\x2\\$\x3\x2\x2\x2]^\a}\x2\x2^&\x3\x2\x2\x2_`\a.\x2"+
		"\x2`(\x3\x2\x2\x2\x61\x63\t\x2\x2\x2\x62\x61\x3\x2\x2\x2\x63\x64\x3\x2"+
		"\x2\x2\x64\x62\x3\x2\x2\x2\x64\x65\x3\x2\x2\x2\x65*\x3\x2\x2\x2\x66g\a"+
		"v\x2\x2gh\at\x2\x2hi\aw\x2\x2ip\ag\x2\x2jk\ah\x2\x2kl\a\x63\x2\x2lm\a"+
		"n\x2\x2mn\au\x2\x2np\ag\x2\x2o\x66\x3\x2\x2\x2oj\x3\x2\x2\x2p,\x3\x2\x2"+
		"\x2qv\a$\x2\x2ru\x5/\x18\x2su\v\x2\x2\x2tr\x3\x2\x2\x2ts\x3\x2\x2\x2u"+
		"x\x3\x2\x2\x2vw\x3\x2\x2\x2vt\x3\x2\x2\x2wy\x3\x2\x2\x2xv\x3\x2\x2\x2"+
		"yz\a$\x2\x2z.\x3\x2\x2\x2{|\a^\x2\x2|\x80\a$\x2\x2}~\a^\x2\x2~\x80\a^"+
		"\x2\x2\x7F{\x3\x2\x2\x2\x7F}\x3\x2\x2\x2\x80\x30\x3\x2\x2\x2\x81\x83\t"+
		"\x3\x2\x2\x82\x81\x3\x2\x2\x2\x83\x84\x3\x2\x2\x2\x84\x82\x3\x2\x2\x2"+
		"\x84\x85\x3\x2\x2\x2\x85\x32\x3\x2\x2\x2\x86\x87\t\x4\x2\x2\x87\x88\x3"+
		"\x2\x2\x2\x88\x89\b\x1A\x2\x2\x89\x34\x3\x2\x2\x2\t\x2\x64otv\x7F\x84"+
		"\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Kitten