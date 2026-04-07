using System;
using System.Collections.Generic;
using System.Linq;

namespace TextLib {
    public interface IKeyGenerator {
        string GetKeyFromWords(string text);
    }

    public class WordLine {
        private string _content;
        public string Content => _content;
        public WordLine(string content) {
            _content = content;
        }

        public void ToUpperFirstLetters() {
            var words = _content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length > 0)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            _content = string.Join(" ", words);
        }
    }

    public class TextContainer : IKeyGenerator {
        private List<WordLine> _lines = new List<WordLine>();
        public void AddLine(string text) => _lines.Add(new WordLine(text));
        public void RemoveLine(int index) {
            if (index >= 0 && index < _lines.Count) _lines.RemoveAt(index);
        }

        public void ClearText() => _lines.Clear();
        public void CapitalizeAll() {
            foreach (var line in _lines) line.ToUpperFirstLetters();
        }
        public int CountLinesWithLength(int length) {
            return _lines.Count(l => l.Content.Length == length);
        }
        public string GetKeyFromWords(string text) {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string key = "";
            foreach (var w in words) key += w[0];
            return key;
        }
        public List<string> GetAllLines() => _lines.Select(l => l.Content).ToList();
    }
}