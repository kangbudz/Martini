using System.Collections.Generic;

namespace Martini
{
    internal class SectionFactory
    {
        public static Sentence CreateSection(string name)
        {
            var section = new Sentence
            {
                Type = SentenceType.Section,
                Tokens = new List<Token>
                {
                    new Token(TokenType.LeftSectionDelimiter),
                    new Token(TokenType.Section, name),
                    new Token(TokenType.RightSectionDelimiter),
                }
            };
            return section;
        }
    }
}