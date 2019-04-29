using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public static class StringExtensions
    {
        public static Dictionary<string, string> Exceptions { get; } = new Dictionary<string, string>()
        {
            { "best", "good" },
            { "better", "good" },
            // ...
            { "is", "be" }, { "am", "be" }, {"are", "be"},
            {"arose", "arise"}, {"arisen", "arise"}, {"awakened", "awake"}, {"awoke", "awake"},
            { "awoken", "awake"}, { "backslid", "backslide"}, {"backslidden", "backslide"}, {"was", "be"},
            { "were", "be"}, { "been", "be"}, {"bore", "bear"}, {"born", "bear"}, {"borne", "bear"},
            { "beat", "beat"}, { "beaten", "beat"}, {"became", "become"}, {"began", "begin"}, {"begun", "begin"},
            { "bent", "bend"}, {"betted", "bet"}, {"bade", "bid"}, {"bidden", "bid"}, {"bound", "bind"},
            { "bit", "bite"}, {"bitten", "bite"}, {"bled", "bleed"}, {"blew", "blow"}, {"blown", "blow"},
            { "broke", "break"}, {"broken", "break"}, {"bred", "breed"}, {"brought", "bring"},
            { "broadcasted", "broadcast"}, {"browbeaten", "browbeat"}, {"built", "build"}, {"burned", "burn"},
            { "burnt", "burn"}, {"busted", "bust"}, {"bought", "buy"}, {"caught", "catch"}, {"chose", "choose"},
            { "chosen", "choose"}, {"clung", "cling"}, {"clothed", "clothe"}, {"clad", "clothe"},
            { "came", "come"}, {"crept", "creep"}, {"crossbred", "crossbreed"}, {"daydreamed", "daydream"},
            { "daydreamt", "daydream"}, {"dealt ", "deal"}, {"dug", "dig"}, {"disproved", "disprove"},
            { "disproven", "disprove"}, {"dove", "dive"}, {"dived", "dive"}, {"did", "do"}, {"done", "do"},
            { "drew", "draw"}, {"drawn", "draw"}, {"dreamed", "dream"}, {"dreamt", "dream"}, {"drank", "drink"},
            { "drunk", "drink"}, {"drove", "drive"}, {"driven", "drive"}, {"dwelt", "dwell"}, {"dwelled", "dwell"},
            { "ate", "eat"}, {"eaten", "eat"}, {"fell", "fall"}, {"fallen", "fall"}, {"fed", "feed"},
            { "felt", "feel"}, {"fought", "fight"}, {"found", "find"}, {"fitted", "fit"}, {"fled", "flee"},
            { "flung", "fling"}, {"flew", "fly"}, {"flown", "fly"}, {"forbade", "forbid"}, {"forbidden", "forbid"},
            { "forewent", "forego"}, { "foregone", "forgo"}, {"foresaw", "foresee"}, {"foreseen", "foresee"},
            { "foretold", "foretell"}, {"forgot", "forget"}, {"forgotten", "forget"}, {"forgave", "forgive"},
            { "forgiven", "forgive"}, {"forsook", "forsake"}, {"forsaken", "forsake"}, {"froze", "freeze"},
            { "frozen", "freeze"}, {"frostbit", "frostbite"}, {"frostbitten", "frostbite"}, {"got", "get"},
            { "gotten", "get"}, {"gave", "give"}, {"given", "give"}, {"went", "go"}, {"gone", "go"},
            { "ground", "grind"}, {"grew", "grow"}, {"grown", "grow"}, {"hand-fed", "hand-feed"},
            { "handwrote", "handwrite"}, {"handwritten", "handwrite"}, {"hung", "hang"}, {"had", "have"},
            { "heard", "hear"}, {"hewed", "hew"}, {"hewn", "hew"}, {"hid", "hide"}, {"hidden", "hide"},
            { "held", "hold"}, {"inbred", "inbreed"}, {"inlaid", "inlay"}, {"inputted", "input"},
            { "interbred", "interbreed"}, {"interwove", "interweave"}, {"interweaved", "interweave"},
            { "interwoven", "interweave"}, {"interwound", "interwind"}, {"jerry-built", "jerry-build"},
            { "kept", "keep"}, {"knelt", "kneel"}, {"kneeled", "kneel"}, {"knitted", "knit"}, {"knew", "know"},
            { "known", "know"}, {"laid", "lay"}, {"led", "lead"}, {"leaned", "lean"}, {"leant", "lean"},
            { "leaped", "leap"}, {"leapt", "leap"}, {"learned", "learn"}, {"learnt", "learn"}, {"left", "leave"},
            { "lent", "lend"}, {"lay", "lie"}, {"lain", "lie"}, {"lied", "lie"}, {"lit", "light"},
            { "lighted", "light"}, {"lost", "lose"}, {"made", "make"}, {"meant", "mean"}, {"met", "meet"},
            { "misdealt", "misdeal"}, {"misdid", "misdo"}, {"misdone", "misdo"}, {"misheard", "mishear"},
            { "mislaid", "mislay"}, {"misled", "mislead"}, {"mislearned", "mislearn"}, {"mislearnt", "mislearn"},
            { "misspoke", "misspeak"}, {"misspoken", "misspeak"}, {"misspelled", "misspell"}, {"misspelt", "misspell"},
            { "misspent", "misspend"}, {"mistook", "mistake"}, {"mistaken", "mistake"}, {"mistaught", "misteach"},
            { "misunderstood", "misunderstand"}, {"miswrote", "miswrite"}, {"miswritten", "miswrite"},
            { "mowed", "mow"}, {"mown", "mow"}, {"outbred", "outbreed"}, {"outdid", "outdo"}, {"outdone", "outdo"},
            { "outdrew", "outdraw"}, {"outdrawn", "outdraw"}, {"outdrank", "outdrink"}, {"outdrunk", "outdrink"},
            { "outdrove", "outdrive"}, {"outdriven", "outdrive"}, {"outfought", "outfight"}, {"outflew", "outfly"},
            { "outflown", "outfly"}, {"outgrew", "outgrow"}, {"outgrown", "outgrow"}, {"outleaped", "outleap"},
            { "outleapt", "outleap"}, {"outlied", "outlie"}, {"outrode", "outride"}, {"outridden", "outride"},
            { "outran", "outrun"}, {"outsold", "outsell"}, {"outshined", "outshine"}, {"outshone", "outshine"},
            { "outshot", "outshoot"}, {"outsang", "outsing"}, {"outsung", "outsing"}, {"outsat", "outsit"},
            { "outslept", "outsleep"}, {"outsmelled", "outsmell"}, {"outsmelt", "outsmell"}, {"outspoke", "outspeak"},
            { "outspoken", "outspeak"}, {"outsped", "outspeed"}, {"outspent", "outspend"}, {"outswore", "outswear"},
            { "outsworn", "outswear"}, {"outswam", "outswim"}, {"outswum", "outswim"}, {"outthought", "outthink"},
            { "outthrew", "outthrow"}, {"outthrown", "outthrow"}, {"outwrote", "outwrite"}, {"outwritten", "outwrite"},
            { "overbred", "overbreed"}, {"overbuilt", "overbuild"}, {"overbought", "overbuy"}, {"overcame", "overcome"},
            { "overdid", "overdo"}, {"overdone", "overdo"}, {"overdrew", "overdraw"}, {"overdrawn", "overdraw"},
            { "overdrank", "overdrink"}, {"overdrunk", "overdrink"}, {"overate", "overeat"}, {"overeaten", "overeat"},
            { "overfed", "overfeed"}, {"overhung", "overhang"}, {"overheard", "overhear"}, {"overlaid", "overlay"},
            { "overpaid", "overpay"}, {"overrode", "override"}, {"overridden", "override"}, {"overran", "overrun"},
            { "oversaw", "oversee"}, {"overseen", "oversee"}, {"oversold", "oversell"}, {"oversewed", "oversew"},
            { "oversewn", "oversew"}, {"overshot", "overshoot"}, {"overslept", "oversleep"}, {"overspoke", "overspeak"},
            { "overspoken", "overspeak"}, {"overspent", "overspend"}, {"overspilled", "overspill"},
            { "overspilt", "overspill"}, {"overtook", "overtake"}, {"overtaken", "overtake"}, {"overthought", "overthink"},
            { "overthrew", "overthrow"}, {"overthrown", "overthrow"}, {"overwound", "overwind"}, {"overwrote", "overwrite"},
            { "overwritten", "overwrite"}, {"partook", "partake"}, {"partaken", "partake"}, {"paid", "pay"},
            { "pleaded", "plead"}, {"pled", "plead"}, {"prebuilt", "prebuild"}, {"predid", "predo"},
            { "predone", "predo"}, {"premade", "premake"}, {"prepaid", "prepay"}, {"presold", "presell"},
            { "preshrank", "preshrink"}, {"preshrunk", "preshrink"}, {"proved", "prove"}, {"proven", "prove"},
            { "quick-froze", "quick-freeze"}, {"quick-frozen", "quick-freeze"}, {"quitted", "quit"},
            { "reawoke", "reawake"}, {"reawaken", "reawake"}, {"rebound", "rebind"}, {"rebroadcasted", "rebroadcast"},
            { "rebuilt", "rebuild"}, {"redealt", "redeal"}, {"redid", "redo"}, {"redone", "redo"}, {"redrew", "redraw"},
            { "redrawn", "redraw"}, {"refitted", "refit"}, {"reground", "regrind"}, {"regrew", "regrow"},
            { "regrown", "regrow"}, {"rehung", "rehang"}, {"reheard", "rehear"}, {"reknitted", "reknit"},
            { "relaid", "relay"}, {"relayed", "relay"}, {"relearned", "relearn"}, {"relearnt", "relearn"},
            { "relit", "relight"}, {"relighted", "relight"}, {"remade", "remake"}, {"repaid", "repay"},
            { "reran", "rerun"}, {"resold", "resell"}, {"resent", "resend"}, {"resewed", "resew"}, {"resewn", "resew"},
            { "retook", "retake"}, {"retaken", "retake"}, {"retaught", "reteach"}, {"retore", "retear"},
            { "retorn", "retear"}, {"retold", "retell"}, {"rethought", "rethink"}, {"retrofitted", "retrofit"},
            { "rewoke", "rewake"}, {"rewore", "rewear"}, {"reworn", "rewear"}, {"rewove", "reweave"},
            { "reweaved", "reweave"}, {"rewoven", "reweave"}, {"rewedded", "rewed"}, {"rewetted", "rewet"},
            { "rewon", "rewin"}, {"rewound", "rewind"}, {"rewrote", "rewrite"}, {"rewritten", "rewrite"},
            { "rode", "ride"}, {"ridden", "ride"}, {"rang", "ring"}, {"rung", "ring"}, {"rose", "rise"},
            { "risen", "rise"}, {"ran", "run"}, {"sawed", "saw"}, {"sawn", "saw"}, {"said", "say"}, {"saw", "see"},
            { "seen", "see"}, {"sought", "seek"}, {"sold", "sell"}, {"sent", "send"}, {"sewed", "sew"},
            { "sewn", "sew"}, {"shook", "shake"}, {"shaken", "shake"}, {"shaved", "shave"}, {"shaven", "shave"},
            { "sheared", "shear"}, {"shorn", "shear"}, {"shined", "shine"}, {"shone", "shine"}, {"shat", "shit"},
            { "shitted", "shit"}, {"shot", "shoot"}, {"showed", "show"}, {"shown", "show"}, {"shrank", "shrink"},
            { "shrunk", "shrink"},  {"sang", "sing"}, {"sung", "sing"}, {"sank", "sink"}, {"sunk", "sink"},
            { "sat", "sit"}, {"slew", "slay"}, {"sleyed", "slay"}, {"slain", "slay (kill)"}, {"slept", "sleep"},
            { "slid", "slide"}, {"slung", "sling"}, {"slinked", "slink"}, {"slunk", "slink"}, {"smelled", "smell"},
            { "smelt", "smell"}, {"sneaked", "sneak"}, {"snuck", "sneak"}, {"sowed", "sow"}, {"sown", "sow"},
            { "spoke", "speak"}, {"spoken", "speak"}, {"sped", "speed"}, {"speeded", "speed"}, {"spelled", "spell"},
            { "spelt", "spell"}, {"spent", "spend"}, {"spilled", "spill"}, {"spilt", "spill"}, {"spun", "spin"},
            { "spat", "spit"}, {"spoiled", "spoil"}, {"spoilt", "spoil"}, {"spoon-fed", "spoon-feed"},
            { "sprang", "spring"}, {"sprung", "spring"}, {"stood", "stand "}, {"stole", "steal"}, {"stolen", "steal"},
            { "stuck", "stick"}, {"stung", "sting"}, {"stank", "stink"}, {"stunk", "stink"}, {"strewed", "strew"},
            { "strewn", "strew"}, {"strode", "stride"}, {"stridden", "stride"}, {"struck", "strike"},
            { "stricken", "strike"}, {"strung", "string"}, {"strove", "strive"}, {"strived", "strive"},
            { "striven", "strive"}, {"sunburned", "sunburn"}, {"sunburnt", "sunburn"}, {"swore", "swear"},
            { "sworn", "swear"}, {"sweated", "sweat"}, {"swept", "sweep"}, {"swelled", "swell"}, {"swollen", "swell"},
            { "swam", "swim"}, {"swum", "swim"}, {"swung", "swing"}, {"took", "take"}, {"taken", "take"},
            { "taught", "teach"}, {"tore", "tear"}, {"torn", "tear"}, {"told", "tell"}, {"test-drove", "test-drive"},
            { "test-driven", "test-drive"}, {"test-flew", "test-fly"}, {"test-flown", "test-fly"},
            { "thought", "think"}, {"threw", "throw"}, {"thrown", "throw"}, {"thrust", "thrust"},
            { "trod", "tread"}, {"trodden", "tread"}, {"typewrote", "typewrite"}, {"typewritten", "typewrite"},
            { "unbent", "unbend"}, {"unbound", "unbind"}, {"unclothed", "unclothe"}, {"unclad", "unclothe"},
            { "underfed", "underfeed"}, {"underwent", "undergo"}, {"undergone", "undergo"}, {"underlay", "underlie"},
            { "underlain", "underlie"}, {"undersold", "undersell"}, {"underspent", "underspend"},
            { "understood", "understand"}, {"undertook", "undertake"}, {"undertaken", "undertake"},
            { "underwrote", "underwrite"}, {"underwritten", "underwrite"}, {"undid", "undo"}, {"undone", "undo"},
            { "unfroze", "unfreeze"}, {"unfrozen", "unfreeze"}, {"unhung", "unhang"}, {"unhid", "unhide"},
            { "unhidden", "unhide"}, {"unknitted", "unknit"}, {"unlearned", "unlearn"}, {"unlearnt", "unlearn"},
            { "unsewed", "unsew"}, {"unsewn", "unsew"}, {"unslung", "unsling"}, {"unspun", "unspin"},
            { "unstuck", "unstick"}, {"unstrung", "unstring"}, {"unwove", "unweave"}, {"unweaved", "unweave"},
            { "unwoven", "unweave"}, {"unwound", "unwind"}, {"upheld", "uphold"}, {"woke", "wake"}, {"waked", "wake"},
            { "woken", "wake"}, {"waylaid", "waylay"}, {"wore", "wear"}, {"worn", "wear"}, {"wove", "weave"},
            { "weaved", "weave"}, {"woven", "weave"}, {"wedded", "wed"}, {"wept", "weep"}, {"wetted", "wet"},
            { "whetted", "whet"}, {"won", "win"}, {"wound", "wind"}, {"withdrew", "withdraw"}, {"withdrawn", "withdraw"},
            { "withheld", "withhold"}, {"withstood", "withstand"}, {"wrung", "wring"}, {"wrote", "write"}, {"written", "write"},
        };

        public static HashSet<char> Vowels { get; } = new HashSet<char> { 'e', 'i', 'o', 'a', 'u' };

        public static HashSet<string> S_Exceptions { get; } = new HashSet<string> { "as", "yes", "this", "across", "miss" };

        /// <summary>
        /// Returns initial form of the word but do not change the word itself.
        /// </summary>
        public static string GetInitialForm(this string word)
        {
            if (Exceptions.ContainsKey(word)) return Exceptions[word];
            if (word[word.Length - 1] == 's' && !S_Exceptions.Contains(word))
            {
                if (word[word.Length - 2] == 'e')
                {
                    if (word[word.Length - 3] == 'i') return word.Substring(0, word.Length - 3) + 'y';
                    if (Vowels.Contains(word[word.Length - 3])) return word.Substring(0, word.Length - 2);
                }
                return word.Substring(0, word.Length - 1);
            }
            if (word.EndsWith("ed"))
            {
                if (word[word.Length - 3] == 'i') return word.Substring(0, word.Length - 3) + 'y';
                return word.Substring(0, word.Length - 2);
            }
            return word;
        }
    }
}
