#include "Line.h"
#include <sstream>
#include <cctype>

WordLine::WordLine(std::string content) : _content(content) {}

std::string WordLine::getContent() const { return _content; }

void WordLine::capitalize() {
    std::stringstream ss(_content);
    std::string word, result;
    while (ss >> word) {
        if (!word.empty()) word[0] = toupper(word[0]);
        result += word + " ";
    }
    if (!result.empty()) result.pop_back();
    _content = result;
}