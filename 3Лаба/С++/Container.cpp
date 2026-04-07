#include "Container.h"
#include <sstream>

void TextContainer::addLine(std::string text) {
    _lines.push_back(WordLine(text));
}

void TextContainer::removeLine(int index) {
    if (index >= 0 && index < _lines.size()) _lines.erase(_lines.begin() + index);
}

void TextContainer::clear() { _lines.clear(); }

void TextContainer::capitalizeAll() {
    for (auto& line : _lines) line.capitalize();
}

std::string TextContainer::getKeyFromWords(std::string text) {
    std::stringstream ss(text);
    std::string word, key;
    while (ss >> word) key += word[0];
    return key;
}

int TextContainer::countWithLength(int len) {
    int count = 0;
    for (const auto& l : _lines) if (l.getContent().length() == len) count++;
    return count;
}