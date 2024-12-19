using System;
using System.Collections.Generic;

namespace ChristmasAsciiArt
{
    public class EmojiOrnamentFactory
    {
        private Random r;

        private List<string> RedOrnaments => ["🔴", "⭕", "😡", "💄", "🍎", "🍒", "🐦", "🐞", "👄", "🎈", "🎀", "🧣", "💋", "🎯", "♥️", "♦️", "🩸", "📍", "📌", "✂️", "🍟", "🍬", "🍄", "🍁", "🌡️", "💞", "💥", "⛔", "🚫", "🩷", "🐷", "🧠", "👚", "🧁", "🌺", "🧼"];
        private List<string> OrangeOrnaments => ["🧡", "🟠", "🟧", "🔶", "🦧", "🎃", "🦺", "🏀", "📙", "🍑", "🏵️", "🥕", "🔥"];
        private List<string> YellowOrnaments => ["😀", "😉", "😮", "😥", "🥸", "🐥", "🐣", "✨", "🎗️", "🥇", "🔔", "🎷", "🗝️", "🔓", "🪝", "📒", "💴", "🪙", "💰", "📁", "🧀", "🌮", "🍋", "🌻", "🪐", "🛎️", "☀️", "💛", "💫", "☢️", "☣️", "🚸", "🟡"];
        private List<string> GreenOrnaments => ["🤢", "👽", "🐸", "🐲", "🐢", "🧩", "🔋", "📗", "💵", "🖍️", "🥝", "🫒", "🥑", "🗽", "💚", "♻️", "🟢", "🟩"];
        private List<string> BlueOrnaments => ["🔵", "🥶", "🔷", "🪻", "🔹", "🐟", "🧶", "🥏", "🧿", "💎", "🥣", "🧊", "🌎", "🌍", "🪣", "❄️", "💧", "💶"];
        private List<string> PurpleOrnaments => ["💜", "🟣", "🟪", "😈", "🦄", "🦑", "🪼", "🫂", "🧤", "🪀", "💷", "🗄️", "🍇", "🫐", "🍆", "🌑", "🌚", "🌂", "☑️", "✔️"];
        private List<string> BrownOrnaments => ["🤎", "🟤", "🟫", "💩", "🐵", "🎠", "🏈", "👞", "👜", "🪵", "🪜", "📦", "🕰️", "🍩", "🧋", "🫘", "🪑"];
        private List<string> BlackOrnaments => ["🖤", "⚫", "⬛", "🎩", "🎓", "🎱", "🔮", "🕹️", "♟️", "♠️", "♣️", "🎵", "🎶", "🎤", "💣", "📱", "🔌", "💾", "📸", "📼", "📓", "✒️", "🍳", "☠️"];
        private List<string> WhiteOrnaments => ["🤍", "⚪", "⬜", "🏳️", "🤖", "🐔", "🐇", "🦴", "💍", "🏐", "⚾", "🪩", "🎧", "🔧", "⚙️", "💿", "🖱️", "📄", "✉️", "🗑️", "🧂", "🥡", "🥛", "🧻", "🚽", "☁️", "☃️", "💨", "🗨️", "👻", "💀"];

        private List<List<string>> AllOrnaments => new List<List<string>> { RedOrnaments, BlueOrnaments , GreenOrnaments, YellowOrnaments, PurpleOrnaments, WhiteOrnaments, BlackOrnaments, OrangeOrnaments, BrownOrnaments };

        public EmojiOrnamentFactory()
        {
            r = new Random(DateTime.Now.Millisecond);
        }
        public string GenerateEmoji()
        {
            var listSelection = r.Next(AllOrnaments.Count);
            var ornamentSelection = r.Next(AllOrnaments[listSelection].Count);

            return AllOrnaments[listSelection][ornamentSelection];
        }
    }
}
